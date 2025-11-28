// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="EventHandlerDescriptor.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件处理方法类</summary>
// ************************************************************************
namespace FeishuNetSdk.Services;

/// <summary>
/// 事件处理方法类
/// </summary>
public class EventHandlerDescriptor
{
    /// <summary>
    /// 事件处理方法名称
    /// </summary>
    public required string EventHandlerName { get; init; }

    /// <summary>
    /// 事件处理类名称 
    /// </summary>
    public required Type EventHandlerType { get; init; }

    /// <summary>
    /// 事件名称 
    /// </summary>
    public required string EventName { get; init; }

    /// <summary>
    /// 事件类型 
    /// </summary>
    public required Type EventType { get; init; }

    /// <summary>
    /// 不允许重复的事件处理方法 
    /// </summary>
    public required bool NotAllowRepeat { get; init; }

    /// <summary>
    /// 缓存反射方法
    /// </summary>
    public required MethodInfo ExecuteMethod { get; init; }
}
