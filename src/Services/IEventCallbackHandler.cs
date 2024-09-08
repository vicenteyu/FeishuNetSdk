// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="IEventCallbackHandler.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件回调处理接口</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件回调处理接口
    /// </summary>
    /// <typeparam name="T1">消息体</typeparam>
    /// <typeparam name="T2">事件体</typeparam>
    public interface IEventCallbackHandler<T1, T2> where T1 : EventDto<T2> where T2 : EventBodyDto
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">消息体</typeparam>
    /// <typeparam name="T2">事件体</typeparam>
    public interface IEventHandler<T1, T2> : IEventCallbackHandler<T1, T2> where T1 : EventDto<T2> where T2 : EventBodyDto
    {
        /// <summary>
        /// 事件执行方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task ExecuteAsync(T1 input);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1">消息体</typeparam>
    /// <typeparam name="T2">事件体</typeparam>
    /// <typeparam name="T3">响应体</typeparam>
    public interface ICallbackHandler<T1, T2, T3> : IEventCallbackHandler<T1, T2>
        where T1 : CallbackV2Dto<T2>
        where T2 : EventBodyDto
        where T3 : CallbackResponseDto
    {
        /// <summary>
        /// 回调执行方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        System.Threading.Tasks.Task<T3> ExecuteAsync(T1 input);
    }
}
