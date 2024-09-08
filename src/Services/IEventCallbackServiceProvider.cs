// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="EventCallbackServiceProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************

namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件回调服务
    /// </summary>
    public interface IEventCallbackServiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<EventCallbackServiceProvider.HandleResult> HandleAsync(object input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        Task<EventCallbackServiceProvider.HandleResult> HandleAsync(string json);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<EventHandlerDescriptor> FindAllHandlers();
    }
}