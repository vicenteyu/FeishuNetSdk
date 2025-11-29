// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2025-11-30
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
    /// 事件处理方法
    /// </summary>
    /// <param name="input">事件体</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns></returns>
    Task<EventCallbackServiceProvider.HandleResult> HandleAsync(
        System.Text.Json.Nodes.JsonNode input,
        CancellationToken cancellationToken = default);
}