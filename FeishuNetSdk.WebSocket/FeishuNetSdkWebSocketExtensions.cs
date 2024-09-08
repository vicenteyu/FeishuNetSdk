// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="FeishuNetSdkWebSocketExtensions.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>提供注册SDK的扩展</summary>
// ************************************************************************
#pragma warning disable IDE0130
namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
{
    /// <summary>
    /// 提供注册SDK的扩展
    /// </summary>
    public static class FeishuNetSdkWebSocketExtensions
    {
        /// <summary>
        /// 注册SDK
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddFeishuWebSocket(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            _ = serviceProvider.GetService<FeishuNetSdk.IFeishuApi>()
                ?? throw new NotSupportedException("缺少关键服务：FeishuNetSdk");
            _ = serviceProvider.GetService<Options.IOptionsMonitor<FeishuNetSdk.FeishuNetSdkOptions>>()
                ?? throw new NotSupportedException("缺少关键服务：FeishuNetSdk");

            services.AddHostedService<FeishuNetSdk.WebSocket.WssService>();
            return services;
        }
    }
}
