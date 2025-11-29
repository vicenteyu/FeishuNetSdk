using FeishuNetSdk;
using FeishuNetSdk.Approval.Events;
using FeishuNetSdk.CallbackEvents;
using FeishuNetSdk.Contact.Events;
using FeishuNetSdk.Extensions;
using FeishuNetSdk.Im.Dtos;
using FeishuNetSdk.Im.Events;
using FeishuNetSdk.Services;
using System.Text.Json;

namespace WebApplication1
{
    /// <summary>
    /// 测试发送卡片消息，ReceiveId = 接收人的 OpenId
    /// 进入 https://open.feishu.cn/document/server-docs/contact-v3/user/patch，
    /// 右侧 API调试台 -> 路径参数 -> user_id -> 点击获取 -> 复制 OpenId
    /// </summary>
    public class Class1(IFeishuTenantApi tenantApi) : BackgroundService
    {
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await tenantApi.PostImV1MessagesAsync("open_id", new FeishuNetSdk.Im.PostImV1MessagesBodyDto()
            {
                ReceiveId = "ou_9ef1*************ede896"
            }.SetContent(new ElementsCardV2Dto()
            {
                Header = new ElementsCardV2Dto.HeaderSuffix() { Title = new("Button-1") },
                Body = new ElementsCardV2Dto.BodySuffix()
                {
                    Elements = [new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])]
                }
            }), stoppingToken);
        }
    }

    /// <summary>
    /// 事件方法
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="tenantApi"></param>
    public class EventHandler1(ILogger<EventHandler> logger, IFeishuTenantApi tenantApi) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input, CancellationToken cancellationToken = default)
        {
            await Task.Delay(600, cancellationToken);
            logger.LogInformation("ExecuteAsync1: {info}", JsonSerializer.Serialize(input));

            var response = await tenantApi.PostImV1MessagesAsync("open_id",
                new FeishuNetSdk.Im.PostImV1MessagesBodyDto()
                {
                    ReceiveId = input.Event?.Sender?.SenderId?.OpenId ?? throw new Exception($"ReceiveId 异常")
                }.SetContent(new ElementsCardV2Dto()
                {
                    Header = new ElementsCardV2Dto.HeaderSuffix() { Title = new("Button-1") },
                    Body = new ElementsCardV2Dto.BodySuffix()
                    {
                        Elements = [
                            new DivElement().SetText(new PlainTextElement("带图标的文本")).SetIcon(new StandardIconElement("check_outlined")),
                            new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])]
                    }
                }), cancellationToken);

            if (!response.IsSuccess)
                throw new Exception(response.Msg);

            logger.LogInformation("ExecuteAsync1 Finish. EventId: {EventId}", input.EventId);
        }
    }

    public class EventHandler1DepartmentCreatedAsync(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ContactDepartmentCreatedV3EventBodyDto>, ContactDepartmentCreatedV3EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ContactDepartmentCreatedV3EventBodyDto> input, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("EventHandler1DepartmentCreatedAsync: {info}", JsonSerializer.Serialize(input));
        }
    }

    public class EventHandler1DepartmentUpdatedAsync(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ContactDepartmentUpdatedV3EventBodyDto>, ContactDepartmentUpdatedV3EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ContactDepartmentUpdatedV3EventBodyDto> input, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("EventHandler1DepartmentUpdatedAsync: {info}", JsonSerializer.Serialize(input));
        }
    }

    public class EventHandler1DepartmentDeletedAsync(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ContactDepartmentDeletedV3EventBodyDto>, ContactDepartmentDeletedV3EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ContactDepartmentDeletedV3EventBodyDto> input, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("EventHandler1DepartmentDeletedAsync: {info}", JsonSerializer.Serialize(input));
        }
    }

    public class EventHandler1WorkApprovaledAsync(ILogger<EventHandler> logger) : IEventHandler<EventV1Dto<WorkApprovalEventBodyDto>, WorkApprovalEventBodyDto>
    {
        public async Task ExecuteAsync(EventV1Dto<WorkApprovalEventBodyDto> input, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("EventHandler1WorkApprovaledAsync: {info}", input);
        }
    }

    /// <summary>
    /// 回调方法
    /// </summary>
    public class MyCallbackHandler(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackV2Dto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
    {
        public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackV2Dto<CardActionTriggerEventBodyDto> input, CancellationToken cancellationToken = default)
        {
            logger.LogWarning("回调方法：{json}", JsonSerializer.Serialize(input));
            //await Task.Delay(3500, cancellationToken);
            await Task.CompletedTask;

            return new CardActionTriggerResponseDto()
            {
                Toast = new()
                {
                    Content = "Toast Content",
                },
            }
            .SetCard(new ElementsCardV2Dto()
            {
                Header = new() { Title = new("Button-updated"), Template = "blue" },
                Config = new() { EnableForward = true },
                Body = new()
                {
                    Elements = [new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])]
                }
            });
        }
    }

    public class EventHandler2(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input, CancellationToken cancellationToken)
        {
            //await Task.Delay(3000, cancellationToken);

            if (logger.IsEnabled(LogLevel.Information))
                logger.LogInformation("ExecuteAsync2: {info}", JsonSerializer.Serialize(input));
        }
    }

    //public class MyClass1(ILogger<MyClass1> logger) : IEventHandler<EventV1Dto<ApprovalEventBodyDto>, ApprovalEventBodyDto>
    //{
    //    public Task ExecuteAsync(EventV1Dto<ApprovalEventBodyDto> input)
    //    {
    //        logger.LogInformation("ExecuteAsync4: {info}", JsonSerializer.Serialize(input));
    //        return Task.CompletedTask;
    //    }
    //}
}
