// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="ShareChatContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分享群名片消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享群名片消息
    /// </summary>
    /// <param name="ShareChatId">群名片Id</param>
    public record ShareChatContent([property: JsonPropertyName("share_chat_id")] string ShareChatId = "") : MessageContent("share_chat");

}
