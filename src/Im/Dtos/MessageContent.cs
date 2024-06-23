// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="MessageContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>消息内容</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 消息内容
    /// </summary>
    /// <param name="MessageType">消息类型</param>
    public abstract record MessageContent(string MessageType) : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType { get; } = MessageType;
    }
}
