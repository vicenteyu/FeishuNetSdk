// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="CallbackV2Dto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回调事件</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 回调事件接口
    /// </summary>
    public interface IAmCallbackDto
    {
    }

    /// <summary>
    /// 回调事件
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record CallbackV2Dto<T> : EventV2Dto<T>, IAmCallbackDto where T : EventBodyDto
    {
    }
}
