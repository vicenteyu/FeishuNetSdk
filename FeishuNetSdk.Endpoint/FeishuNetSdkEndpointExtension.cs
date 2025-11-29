// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2025-11-30
// ************************************************************************
// <copyright file="FeishuNetSdkEndpointExtension.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提供飞书事件回调地址服务的扩展</summary>
// ************************************************************************
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

#pragma warning disable IDE0130
namespace Microsoft.Extensions.DependencyInjection;
#pragma warning restore IDE0130

/// <summary>
/// 启用飞书事件回调地址服务
/// </summary>
public static class FeishuNetSdkEndpointExtension
{
    // 最佳实践：将 JsonSerializerOptions 设为静态只读字段
    private static readonly JsonSerializerOptions s_serializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// 注册 FeishuNetSdk 的 终结点 服务。
    /// </summary>
    /// <param name="builder">路由构建器。</param>
    /// <param name="pattern">事件回调的URL路径模式，例如 "/feishu/callback"。</param>
    /// <returns>返回传入的 IEndpointRouteBuilder 实例，以支持链式调用。</returns>
    public static IEndpointRouteBuilder UseFeishuEndpoint(this IEndpointRouteBuilder builder, string pattern)
    {
        // 使用 builder.MapPost 进行注册
        builder.MapPost(pattern, FeishuCallbackHandler)
            .WithName("FeishuEventCallback")
            .Accepts<JsonNode>("application/json")
            .Produces(StatusCodes.Status200OK)
            .Produces<JsonNode>(StatusCodes.Status200OK, "application/json")
            .ProducesProblem(StatusCodes.Status500InternalServerError);

        return builder;
    }

    /// <summary>
    /// 终结点处理函数：统一处理飞书的事件回调请求。
    /// </summary>
    private static async Task<IResult> FeishuCallbackHandler(
        FeishuNetSdk.Services.IEventCallbackServiceProvider provider,
        ILoggerFactory loggerFactory, // 注入 LoggerFactory
        JsonNode jsonPayload,
        CancellationToken cancellationToken)
    {
        var logger = loggerFactory.CreateLogger(typeof(FeishuNetSdkEndpointExtension));

        if (logger.IsEnabled(LogLevel.Debug))
            logger.LogDebug("Feishu回调终结点收到的入参: {json}", jsonPayload.ToJsonString());

        if (jsonPayload == null)
        {
            logger.LogWarning("收到的飞书回调请求体为空或无法解析为 JsonNode.");
            return Results.BadRequest("Request body is empty or invalid JSON.");
        }

        var result = await provider.HandleAsync(jsonPayload, cancellationToken);

        if (logger.IsEnabled(LogLevel.Debug))
            logger.LogDebug("飞书回调终结点处理结果: {json}",
                result != null ? JsonSerializer.Serialize(result, s_serializerOptions) : "NULL_RESULT");

        // 处理结果返回
        if (result?.Success != true)
        {
            return Results.Problem(
                title: "Feishu Callback Handling Failed",
                detail: result?.Error ?? "Unknown error occurred.",
                statusCode: StatusCodes.Status500InternalServerError);
        }

        // 返回包含 DTO 的 JSON 响应
        if (result?.Dto != null)
        {
            // 使用静态的 JsonSerializerOptions
            return Results.Json(result.Dto, s_serializerOptions);
        }

        // 成功，无内容返回
        return Results.Ok();
    }
}