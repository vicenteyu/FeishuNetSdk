// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdManagersDeleteManagersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除群管理员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除群管理员 响应体
/// <para>删除指定的群管理员（用户或机器人）。</para>
/// <para>接口ID：6995085510524715009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fdelete_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersDeleteManagersResponseDto
{
    /// <summary>
    /// <para>群目前用户类型的管理员 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_managers")]
    public string[]? ChatManagers { get; set; }

    /// <summary>
    /// <para>群目前机器人类型的管理员 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_bot_managers")]
    public string[]? ChatBotManagers { get; set; }
}
