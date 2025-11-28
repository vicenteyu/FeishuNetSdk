// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2025-08-27
// ************************************************************************
// <copyright file="EventCallbackServiceProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************

namespace FeishuNetSdk.Services;

/// <summary>
/// 事件回调服务
/// </summary>
public interface IEventCallbackServiceProvider
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<EventCallbackServiceProvider.HandleResult> HandleAsync(object input, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="json"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<EventCallbackServiceProvider.HandleResult> HandleAsync(string json, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerable<EventHandlerDescriptor> FindAllHandlers();
}