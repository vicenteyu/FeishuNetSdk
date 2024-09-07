using FeishuNetSdk.Approval.Events;
using FeishuNetSdk.CallbackEvents;
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
    //添加飞书长连接
    .AddFeishuWebSocket();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Host.UseSerilog(Log.Logger);
//builder.Services.AddHostedService<Class1>();

var app = builder.Build();
app.UsePathBase("/feishunetsdktest");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//启用飞书事件回调地址服务
app.UseFeishuEndpoint("/a/b/c/d");

app.Run();

namespace WebApplication1
{
    public class EventHandler1(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
        {
            await Task.Delay(600);
            logger.LogInformation("ExecuteAsync1: {info}", System.Text.Json.JsonSerializer.Serialize(input));
        }
    }

    public class EventHandler3(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
        {
            await Task.Delay(2500);
            logger.LogInformation("ExecuteAsync3: {info}", System.Text.Json.JsonSerializer.Serialize(input));
        }
    }


    public class MyClass1(ILogger<MyClass1> logger) : IEventHandler<EventV1Dto<ApprovalEventBodyDto>, ApprovalEventBodyDto>
    {
        public Task ExecuteAsync(EventV1Dto<ApprovalEventBodyDto> input)
        {
            logger.LogInformation("ExecuteAsync4: {info}", System.Text.Json.JsonSerializer.Serialize(input));
            return Task.CompletedTask;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MyCallbackHandler(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackDto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
    {
        public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackDto<CardActionTriggerEventBodyDto> input)
        {
            await Task.Delay(2900);
            logger.LogWarning("{json}", JsonSerializer.Serialize(input));

            return new();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    //public class MyCallbackHandler2(ILogger<MyCallbackHandler> logger) : ICallbackHandler<CallbackDto<CardActionTriggerEventBodyDto>, CardActionTriggerEventBodyDto, CardActionTriggerResponseDto>
    //{
    //    public async Task<CardActionTriggerResponseDto> ExecuteAsync(CallbackDto<CardActionTriggerEventBodyDto> input)
    //    {
    //        await Task.Delay(1900);
    //        logger.LogWarning("{json}", JsonSerializer.Serialize(input));

    //        return new();
    //    }
    //}
    public class EventHandler2(ILogger<EventHandler> logger) : IEventHandler<EventV2Dto<ImMessageReceiveV1EventBodyDto>, ImMessageReceiveV1EventBodyDto>
    {
        public async Task ExecuteAsync(EventV2Dto<ImMessageReceiveV1EventBodyDto> input)
        {
            await Task.Delay(1200);
            logger.LogInformation("ExecuteAsync2: {info}", System.Text.Json.JsonSerializer.Serialize(input));
            throw new NotImplementedException();
        }
    }
}
