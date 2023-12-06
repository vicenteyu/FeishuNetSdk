using FeishuNetSdk;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.AccessControl;

namespace WebApiClientCore.Attributes
{
    /// <summary>
    /// 启用日志
    /// </summary>
    public class EnableLoggingFilterAttribute : ApiFilterAttribute
    {
        private static readonly LoggingFilterAttribute _loggingFilter = new();

        /// <summary>
        /// 启用时，不再输出缓存内容。
        /// </summary>
        public bool EnableCacheLogging { get; set; } = true;

        /// <summary>
        /// 请求之前
        /// </summary>
        public async override Task OnRequestAsync(ApiRequestContext context)
        {
            if (!IsEnable(context.HttpContext)) return;
            await _loggingFilter.OnRequestAsync(context);
        }

        /// <summary>
        /// 响应之后
        /// </summary>
        public async override Task OnResponseAsync(ApiResponseContext context)
        {
            if (!IsEnable(context.HttpContext)) return;

            if (EnableCacheLogging
                && context.HttpContext.ResponseMessage?.Headers?
                    .TryGetValues("Response-Cache-Provider", out var values) == true
                && values?.Any() == true)
            {
                context.HttpContext.ResponseMessage ??= new HttpResponseMessage();
                context.HttpContext.ResponseMessage.Content = new StringContent("...来自缓存...");
            }

            await _loggingFilter.OnResponseAsync(context);
        }

        private static bool IsEnable(HttpContext context)
        {
            var sdkOptions = context.ServiceProvider
                .GetRequiredService<IOptionsMonitor<FeishuNetSdkOptions>>();
            return sdkOptions.CurrentValue.EnableLogging;
        }
    }
}
