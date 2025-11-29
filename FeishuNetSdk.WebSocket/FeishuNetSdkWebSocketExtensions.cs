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
namespace Microsoft.Extensions.DependencyInjection;
#pragma warning restore IDE0130

/// <summary>
/// 提供注册SDK的扩展
/// </summary>
public static class FeishuNetSdkWebSocketExtensions
{
    /// <summary>
    /// 注册 FeishuNetSdk 的 WebSocket 服务。
    /// 依赖于 IFeishuApi 和 IOptionsMonitor&lt;FeishuNetSdkOptions&gt; 服务已注册。
    /// </summary>
    /// <param name="services">用于注册服务的 IServiceCollection。</param>
    /// <returns>返回传入的 IServiceCollection 实例，以支持链式调用。</returns>
    /// <exception cref="ArgumentNullException">当 services 参数为空时抛出。</exception>
    public static IServiceCollection AddFeishuWebSocket(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);
        services.AddHostedService<FeishuNetSdk.WebSocket.WssService>();

        return services;
    }
}