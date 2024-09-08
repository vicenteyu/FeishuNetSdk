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
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件处理方法类
    /// </summary>
    public class EventHandlerDescriptor
    {
        /// <summary>
        /// 事件处理方法名称
        /// </summary>
        public required string EventHandlerName { get; set; }

        /// <summary>
        /// 事件处理类名称
        /// </summary>
        public required Type EventHandlerType { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        public required string EventName { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        public required Type EventType { get; set; }

        /// <summary>
        /// 不允许重复的事件处理方法
        /// </summary>
        public bool NotAllowRepeat { get; set; }
    }
}
