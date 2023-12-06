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
    public class EnableLoggingFilterAttribute : LoggingFilterAttribute
    {
        /// <summary>
        /// 启用时，不再输出缓存内容。
        /// </summary>
        public bool EnableCacheLogging { get; set; } = true;

        /// <summary>
        /// 写日志到指定日志组件
        /// 默认写入Microsoft.Extensions.Logging
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="logMessage">日志消息</param>
        /// <returns>Task.</returns>
        protected override Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage)
        {
            var sdkOptions = context.HttpContext.ServiceProvider
                   .GetRequiredService<IOptionsMonitor<FeishuNetSdkOptions>>();

            if (!sdkOptions.CurrentValue.EnableLogging) return Task.CompletedTask;

            if (EnableCacheLogging
                && context.HttpContext.ResponseMessage?.Headers?
                    .TryGetValues("Response-Cache-Provider", out var values) == true
                && values?.Any() == true)
            {
                logMessage.ResponseContent = "...来自缓存...";
            }

            return base.WriteLogAsync(context, logMessage);
        }

        /// <summary>
        /// 写日志到ILogger
        /// </summary>
        /// <param name="logger">日志</param>
        /// <param name="logMessage">日志消息</param>
        protected override void WriteLog(ILogger logger, LogMessage logMessage)
        {
            if (logMessage.Exception == null)
            {
                logger.LogInformation("\n{info}", logMessage.ToString());
            }
            else
            {
                logger.LogError("\n{error}", logMessage.ToString());
            }
        }
    }
}
