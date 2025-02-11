using FeishuNetSdk;
using FeishuNetSdk.CallbackEvents;
using FeishuNetSdk.Im.Dtos;
using FeishuNetSdk.Im.Events;
using FeishuNetSdk.Services;
using Serilog;
using System.Text.Json;
using WebApplication1;

Log.Logger = new LoggerConfiguration()
    .Normal()
    .CreateBootstrapLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddFeishuNetSdk(
        AppId: "cli_a38*************013",
        AppSecret: "H2wlkn*************UBfyVn",
        EncryptKey: "75vyV*************Clrwpkjy",
        VerificationToken: "WVr*************MSJw")
    //添加 长连接 服务
    .AddFeishuWebSocket();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Host.UseSerilog(Log.Logger);

//每次启动应用会自动发送一条卡片消息用于测试卡片回调，如果不需要，则注释下面一行。
builder.Services.AddHostedService<Class1>();

var app = builder.Build();
app.UsePathBase("/feishunetsdktest");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//启用飞书事件回调地址服务
app.UseFeishuEndpoint("/a/b/c/d");

app.Run();

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
            }));
        }
    }

    public class EventHandler1(ILogger<EventHandler> logger, IFeishuTenantApi tenantApi) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
        {
            await Task.Delay(600);
            logger.LogInformation("ExecuteAsync1: {info}", JsonSerializer.Serialize(input));

            await tenantApi.PostImV1MessagesAsync("open_id", new FeishuNetSdk.Im.PostImV1MessagesBodyDto()
            {
                ReceiveId = input.Event?.Sender?.SenderId?.OpenId ?? throw new Exception($"ReceiveId 异常")
            }.SetContent(new ElementsCardV2Dto()
            {
                Header = new ElementsCardV2Dto.HeaderSuffix() { Title = new("Button-1") },
                Body = new ElementsCardV2Dto.BodySuffix()
                {
                    Elements = [new FormButtonElement(Name: Guid.NewGuid().ToString(), Text: new($"xxx1{DateTime.Now}"), Behaviors: [new CallbackBehaviors(new { key = "CallbackBehaviors" })])]
                }
            }));
        }
    }

    //public class EventHandler3(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    //{
    //    public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
    //    {
    //        await Task.Delay(1500);
    //        logger.LogInformation("ExecuteAsync3: {info}", JsonSerializer.Serialize(input));
    //    }
    //}


    //public class MyClass1(ILogger<MyClass1> logger) : IEventHandler<EventV1Dto<ApprovalEventBodyDto>, ApprovalEventBodyDto>
    //{
    //    public Task ExecuteAsync(EventV1Dto<ApprovalEventBodyDto> input)
    //    {
    //        logger.LogInformation("ExecuteAsync4: {info}", JsonSerializer.Serialize(input));
    //        return Task.CompletedTask;
    //    }
    //}

    /// <summary>
    /// 
    /// </summary>
    public class MyCallbackHandler(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackV2Dto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
    {
        public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackV2Dto<CardActionTriggerEventBodyDto> input)
        {
            await Task.CompletedTask;
            logger.LogWarning("{json}", JsonSerializer.Serialize(input));

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

    /// <summary>
    /// 
    /// </summary>
    //public class MyCallbackHandler2(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackV2Dto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
    //{
    //    public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackV2Dto<CardActionTriggerEventBodyDto> input)
    //    {
    //        await Task.Delay(1900);
    //        logger.LogWarning("{json}", JsonSerializer.Serialize(input));

    //        return new();
    //    }
    //}

    //public class EventHandler2(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    //{
    //    public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
    //    {
    //        await Task.Delay(1200);
    //        logger.LogInformation("ExecuteAsync2: {info}", System.Text.Json.JsonSerializer.Serialize(input));
    //    }
    //}
}
