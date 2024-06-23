// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="MessageCard.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>消息卡片</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 消息卡片
    /// </summary>
    /// <param name="MessageType">消息类型固定为：interactive</param>
    public abstract record MessageCard([property: JsonIgnore] string MessageType = "interactive") : IHasMessageType;
}
