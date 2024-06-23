// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="ShareUserContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分享个人名片消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享个人名片消息
    /// </summary>
    /// <param name="UserId">个人名片Id</param>
    public record ShareUserContent([property: JsonPropertyName("user_id")] string UserId = "") : MessageContent("share_user");

}
