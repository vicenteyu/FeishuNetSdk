using WebApiClientCore.Attributes;
using WebApiClientCore.Exceptions;
using WebApiClientCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace FeishuNetSdk.Attributes;
/// <summary>
/// 忽略状态异常
/// </summary>
public class IgnoreStatusExceptionFilterAttribute : ApiFilterAttribute
{
    /// <summary>
    /// 请求之前
    /// </summary>
    public override System.Threading.Tasks.Task OnRequestAsync(ApiRequestContext context)
    {
        return System.Threading.Tasks.Task.CompletedTask;
    }

    /// <summary>
    /// 响应之后
    /// </summary>
    public override async System.Threading.Tasks.Task OnResponseAsync(ApiResponseContext context)
    {
        var sdkOptions = context.HttpContext.ServiceProvider
            .GetRequiredService<IOptionsMonitor<FeishuNetSdkOptions>>();
        if (!sdkOptions.CurrentValue.IgnoreStatusException)
            return;

        if (context.Exception is ApiResponseStatusException statusException && statusException != null)
        {
            if (!context.ApiAction.Return.DataType.IsRawType && context.HttpContext.ResponseMessage != null)
            {
                string content = await context.HttpContext.ResponseMessage.Content.ReadAsStringAsync();
                context.Result = JsonSerializer.Deserialize(content, context.ApiAction.Return.DataType.Type);
            }
            else
            {
                context.Result = context.HttpContext.ResponseMessage;
            }
        }
    }
}
