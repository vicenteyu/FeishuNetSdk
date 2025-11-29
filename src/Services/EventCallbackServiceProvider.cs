// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2025-11-30
// ************************************************************************
// <copyright file="EventCallbackServiceProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using FeishuNetSdk.CallbackEvents;
using FeishuNetSdk.Im.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FeishuNetSdk.Services;

/// <summary>
/// 事件回调服务
/// </summary>
/// <param name="logger"></param>
/// <param name="options"></param>
/// <param name="scopeFactory"></param>
public class EventCallbackServiceProvider(
    ILogger<EventCallbackServiceProvider> logger,
    IOptionsMonitor<FeishuNetSdkOptions> options,
    IServiceScopeFactory scopeFactory)
    : IEventCallbackServiceProvider
{
    /// <summary>
    /// 事件处理器缓存（应用生命周期内仅初始化一次）
    /// </summary>
    private static readonly Lazy<EventHandlerDescriptor[]> _handlerCache =
        new(InitializeHandlers, LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    /// 飞书API固定超时配置（3秒内必须响应，预留300ms网络时间）
    /// </summary>
    private const int TimeoutMilliseconds = 2700;
    private const string TimeoutMessage = "执行超时：未能在限制内完成处理（飞书API限制）";
    private static readonly string RawCardType = "raw";

    /// <summary>
    /// 初始化事件处理器（应用启动时执行一次）
    /// </summary>
    private static EventHandlerDescriptor[] InitializeHandlers()
    {
        var baseType = typeof(IEventCallbackHandler<,>);
        var handlers = ReflectionHelper.GetFinalSubTypes(baseType)
            .Select(CreateHandlerDescriptor)
            .ToArray();

        ValidateHandlerUniqueness(handlers);
        return handlers;
    }

    /// <summary>
    /// 创建事件处理器描述符（新增：缓存ExecuteAsync方法信息）
    /// </summary>
    private static EventHandlerDescriptor CreateHandlerDescriptor(Type handlerType)
    {
        var eventType = GetEventTypeFromHandler(handlerType);
        var executeMethod = GetExecuteMethodInfo(handlerType, eventType); // 预缓存方法信息

        return new EventHandlerDescriptor
        {
            EventHandlerName = handlerType.Name,
            EventHandlerType = handlerType,
            EventName = eventType.Name,
            EventType = eventType,
            NotAllowRepeat = eventType.IsAssignableTo(typeof(IAmCallbackDto)),
            ExecuteMethod = executeMethod // 存储方法信息
        };
    }

    /// <summary>
    /// 预缓存ExecuteAsync方法信息（新增）
    /// </summary>
    private static MethodInfo GetExecuteMethodInfo(Type handlerType, Type eventType)
    {
        var method = handlerType.GetMethod(
            "ExecuteAsync",
            [eventType, typeof(CancellationToken)]
        ) ?? throw new InvalidOperationException(
            $"处理器 {handlerType} 未实现 ExecuteAsync({eventType}, CancellationToken)"
        );

        if (method.ReturnType != typeof(System.Threading.Tasks.Task) && !method.ReturnType.IsGenericType)
        {
            throw new InvalidOperationException(
                $"处理器 {handlerType} 的 ExecuteAsync 方法必须返回 Task 或 Task<T>"
            );
        }

        return method;
    }

    /// <summary>
    /// 验证处理器唯一性
    /// </summary>
    private static void ValidateHandlerUniqueness(EventHandlerDescriptor[] handlers)
    {
        var duplicateEvents = handlers.Where(h => h.NotAllowRepeat)
            .GroupBy(h => h.EventType)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key.FullName);

        if (duplicateEvents.Any())
        {
            throw new InvalidOperationException(
                $"重复定义的回调处理方法：{string.Join("、", duplicateEvents)}");
        }
    }

    /// <summary>
    /// 获取事件类型
    /// </summary>
    private static Type GetEventTypeFromHandler(Type handlerType)
    {
        return handlerType.GetTypeInfo()
            .ImplementedInterfaces
            .Single(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEventCallbackHandler<,>))
            .GetGenericArguments()
            .First();
    }

    /// <summary>
    /// 查找所有事件处理程序
    /// </summary>
    public static IEnumerable<EventHandlerDescriptor> FindAllHandlers() => _handlerCache.Value;

    /// <summary>
    /// 修复鉴别器，并确保鉴别器属性在序列化后的 JSON 字符串中位于第一位。
    /// </summary>
    /// <param name="input">原始的 JSON 对象。</param>
    /// <param name="discriminatorPropertyName">鉴别器属性名。</param>
    /// <returns>包含正确顺序鉴别器的 JSON 字符串。</returns>
    public static string FixDiscriminator(JsonNode input,
        string discriminatorPropertyName = FeishuNetSdkOptions.Discriminator.EventType)
    {
        if (input is not JsonObject originalObject)
            throw new InvalidOperationException("仅支持 JSON Object 对象");

        // 提取真实的事件类型
        string? realEventType = ExtractEventType(originalObject);

        if (realEventType is null)
        {
            return originalObject.ToJsonString();
        }

        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = false });

        writer.WriteStartObject();

        // 强制将鉴别器作为第一个属性写入
        writer.WriteString(discriminatorPropertyName, realEventType);

        foreach (var property in originalObject)
        {
            if (property.Key.Equals(discriminatorPropertyName, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }
            writer.WritePropertyName(property.Key);
            property.Value?.WriteTo(writer);
        }

        writer.WriteEndObject();
        writer.Flush();

        return System.Text.Encoding.UTF8.GetString(stream.ToArray());
    }

    // 提取事件类型的辅助方法
    private static string? ExtractEventType(JsonObject jsonObject)
    {
        //2.0
        if (jsonObject.TryGetPropertyValue("header", out var headerNode)
            && headerNode is JsonObject headerObject
            && headerObject.TryGetPropertyValue("event_type", out var eventTypeNode2)
            && eventTypeNode2?.GetValueKind() == JsonValueKind.String)
        {
            return eventTypeNode2.GetValue<string>();
        }
        //1.0
        else if (jsonObject.TryGetPropertyValue("event", out var eventNode)
            && eventNode is JsonObject eventObject
            && eventObject.TryGetPropertyValue("type", out var eventTypeNode1)
            && eventTypeNode1?.GetValueKind() == JsonValueKind.String)
        {
            return eventTypeNode1.GetValue<string>();
        }
        //url_verification
        else if (jsonObject.TryGetPropertyValue("type", out var eventType)
            && eventType?.GetValueKind() == JsonValueKind.String)
        {
            return eventType.GetValue<string>();
        }
        return null;
    }

    /// <summary>
    /// 处理事件入口
    /// </summary>
    public async Task<HandleResult> HandleAsync(JsonNode input, CancellationToken cancellationToken = default)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(TimeoutMilliseconds);

        if (input is not JsonObject jo)
            return new HandleResult(Error: "只支持 JSON Object 对象");

        try
        {
            if (jo.TryGetPropertyValue("encrypt", out var encrypt) && encrypt?.GetValueKind() == JsonValueKind.String)
            {
                if (logger.IsEnabled(LogLevel.Debug))
                    logger.LogDebug("加密消息：{json}", input.ToJsonString());

                var encrypt_string = encrypt.GetValue<string>();
                var decrypt_bytes = DecryptStringAsBytes(encrypt_string);
                using var ms = new MemoryStream(decrypt_bytes);
                input = JsonNode.Parse(ms) ?? throw new InvalidDataException();
            }

            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("事件入参：{json}", input.ToJsonString());

            var event_node = FixDiscriminator(input);
            var dto = JsonSerializer.Deserialize<EventDto>(event_node);

            switch (dto)
            {
                case null:
                    return new HandleResult(Error: "反序列化事件体失败");

                case UrlVerificationDto verificationDto:
                    return new HandleResult(true, Dto: verificationDto);

                default:
                    if (logger.IsEnabled(LogLevel.Debug))
                        logger.LogDebug("反序列化成功 {EventType}", dto.Discriminator);

                    if (!string.IsNullOrWhiteSpace(dto.Token) && dto.Token != options.CurrentValue.VerificationToken)
                        return new HandleResult(Error: "应用标识不一致");

                    return await ProcessEventDtoAsync(dto, cts.Token);
            }
        }
        catch (Exception ex)
        {
            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("事件处理入口异常：{input}", input.ToString());

            return new HandleResult(Error: $"事件处理失败：{UnwrapException(ex).Message}");
        }
    }

    /// <summary>
    /// 处理输入加密
    /// </summary>
    private byte[] DecryptStringAsBytes(string encryptedString)
    {
        if (options.CurrentValue.EncryptKey == null)
        {
            throw new InvalidOperationException("未设置解密密钥");
        }

        try
        {
            return AesCipher.DecryptStringAsBytes(encryptedString, options.CurrentValue.EncryptKey);
        }
        catch (FormatException ex)
        {
            throw new CryptographicException("Base64格式无效", ex);
        }
        catch (CryptographicException ex)
        {
            throw new CryptographicException("解密失败（密钥或数据错误）", ex);
        }
    }

    /// <summary>
    /// 处理事件DTO
    /// </summary>s
    private async Task<HandleResult> ProcessEventDtoAsync(EventDto eventDto, CancellationToken cancellationToken)
    {
        var handlers = FindAllHandlers()
            .Where(h => h.EventType == eventDto.GetType())
            .ToArray();

        if (handlers.Length == default)
        {
            var error = $"未定义事件处理方法：{eventDto.Discriminator}";

            if (logger.IsEnabled(LogLevel.Error))
                logger.LogError("Error: {msg}", error);

            return new HandleResult(Error: error);
        }

        (bool iscallback, string event_type) = eventDto is IAmCallbackDto ? (true, "回调") : (false, "事件");

        if (logger.IsEnabled(LogLevel.Debug))
            logger.LogDebug("找到 {HandlerCount} 个 {event} 处理方法", handlers.Length, event_type);

        using var scope = scopeFactory.CreateScope();
        return iscallback
            ? await ExecuteSingleHandlerAsync(handlers[0], eventDto, scope.ServiceProvider, cancellationToken)
            : await ExecuteMultipleHandlersAsync(handlers, eventDto, scope.ServiceProvider, cancellationToken);
    }

    /// <summary>s
    ///执行单个处理器（回调事件）
    /// </summary>
    private async Task<HandleResult> ExecuteSingleHandlerAsync(
        EventHandlerDescriptor handler,
        EventDto eventDto,
        IServiceProvider serviceProvider,
        CancellationToken cancellationToken) // 直接使用外层cancellationToken
    {
        try
        {
            var handlerInstance = serviceProvider.GetRequiredService(handler.EventHandlerType);
            var parameters = new object[] { eventDto, cancellationToken }; // 使用缓存的方法信息
            var task = (System.Threading.Tasks.Task)handler.ExecuteMethod.Invoke(handlerInstance, parameters)!;
            await task.WaitAsync(cancellationToken); // 仅使用外层超时控制
            var result = ExtractTaskResult(handler.ExecuteMethod, task);
            return new HandleResult(true, Dto: result);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("处理器 {HandlerName} 已因超时被取消", handler.EventHandlerName);
            return new HandleResult(Error: TimeoutMessage, Dto: CreateResponse("任务执行超时")); // 统一返回超时响应
        }
        catch (Exception ex)
        {
            if (logger.IsEnabled(LogLevel.Error))
                logger.LogError(ex, "处理器 {HandlerType} 执行异常", handler.EventHandlerType);
            return new HandleResult(Error: $"处理器执行失败：{UnwrapException(ex).Message}");
        }
    }

    /// <summary>
    /// 执行多个处理器（普通事件）
    /// </summary>
    private async Task<HandleResult> ExecuteMultipleHandlersAsync(
        EventHandlerDescriptor[] handlers,
        EventDto eventDto,
        IServiceProvider serviceProvider,
        CancellationToken cancellationToken)
    {
        var tasks = handlers.Select(h =>
            ExecuteHandlerAsync(h, eventDto, serviceProvider, cancellationToken)
        ).ToArray();

        try
        {
            // 等待所有任务完成或超时
            await System.Threading.Tasks.Task.WhenAll(tasks).WaitAsync(cancellationToken); // 合并超时控制

            var failedResults = tasks
                .Where(t => t.IsCompletedSuccessfully && !t.Result.Success)
                .Select(t => t.Result.Error)
                .ToList();

            if (failedResults.Count != default)
            {
                return new HandleResult(Error: $"部分处理器失败：{string.Join("; ", failedResults)}");
            }

            return new HandleResult(true);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            return new HandleResult(Error: TimeoutMessage);
        }
    }

    /// <summary>
    /// 执行单个处理器（支持取消令牌传递）
    /// </summary>
    private async Task<HandleResult> ExecuteHandlerAsync(
        EventHandlerDescriptor handler,
        object eventDto,
        IServiceProvider serviceProvider,
        CancellationToken cancellationToken)
    {
        try
        {
            // 使用缓存的方法
            var handlerInstance = serviceProvider.GetRequiredService(handler.EventHandlerType);

            var task = (System.Threading.Tasks.Task)handler.ExecuteMethod.Invoke(handlerInstance, [eventDto, cancellationToken])!;
            await task.WaitAsync(cancellationToken); // 仅使用外层传递令牌

            var result = ExtractTaskResult(handler.ExecuteMethod, task);
            return new HandleResult(true, Dto: result);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        { // 仅处理外部取消
            if (logger.IsEnabled(LogLevel.Debug))
                logger.LogDebug("处理器 {HandlerName} 已因超时被取消", handler.EventHandlerName);
            return new HandleResult(Error: TimeoutMessage);
        }
        catch (Exception ex)
        {
            if (logger.IsEnabled(LogLevel.Error))
                logger.LogError(ex, "处理器 {HandlerType} 执行异常", handler.EventHandlerType);
            return new HandleResult(Error: $"处理器执行失败：{UnwrapException(ex).Message}");
        }
    }

    /// <summary>
    /// 提取任务结果
    /// </summary>
    private static object? ExtractTaskResult(MethodInfo method, System.Threading.Tasks.Task task)
    {
        return method.ReturnType.IsGenericType
            ? method.ReturnType.GetProperty("Result")?.GetValue(task)
            : null;
    }

    /// <summary>
    /// 解包异常（处理反射调用的 TargetInvocationException）
    /// </summary>
    private static Exception UnwrapException(Exception ex)
    {
        while (ex is AggregateException || ex is TargetInvocationException)
        {
            ex = ex.InnerException ?? ex; // 确保不会因null内层异常死循环
        }
        return ex;
    }

    /// <summary>
    /// 卡片回调响应
    /// </summary>
    public static CardActionTriggerResponseDto CreateResponse(
        string message,
        bool isSuccess = false,
        ElementsCardV2Dto? card = null)
    {
        var response = new CardActionTriggerResponseDto
        {
            Toast = new()
            {
                Type = isSuccess
                    ? CardActionTriggerResponseDto.ToastSuffix.ToastType.Success
                    : CardActionTriggerResponseDto.ToastSuffix.ToastType.Error,
                Content = message
            }
        };

        if (card != null)
        {
            response.Card = new()
            {
                Type = RawCardType,
                Data = card
            };
        }

        return response;
    }

    /// <summary>
    /// 事件处理结果
    /// </summary>
    public record HandleResult(
        [property: JsonPropertyName("success")] bool Success = false,
        [property: JsonPropertyName("error")] string? Error = null,
        [property: JsonPropertyName("dto")] object? Dto = null);
}
