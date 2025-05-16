// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="IgnoreStatusExceptionFilterAttribute.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>忽略状态异常</summary>
// ************************************************************************
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Text.Json;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Exceptions;

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
        if (context.Exception is ApiResponseStatusException statusException && statusException != null)
        {
            var sdkOptions = context.HttpContext.ServiceProvider
                .GetRequiredService<IOptionsMonitor<FeishuNetSdkOptions>>();

            if (!sdkOptions.CurrentValue.IgnoreStatusException)
                return;

            if (!context.ActionDescriptor.Return.DataType.IsRawType && context.HttpContext.ResponseMessage != null)
            {
                string content = await context.HttpContext.ResponseMessage.Content.ReadAsStringAsync();
                bool isJson = context.HttpContext.ResponseMessage.Content.Headers.IsJsonContent();

                context.Result = JsonSerializer.Deserialize(
                    isJson ? content : JsonSerializer.Serialize(new { msg = $"{statusException.Message} - {content}" }),
                    context.ActionDescriptor.Return.DataType.Type);
            }
        }
    }
}
