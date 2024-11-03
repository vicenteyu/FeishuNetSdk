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
/// <para>指定群组，删除群组内指定的管理员，包括用户类型的管理员和机器人类型的管理员。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>仅群组内的群主可以删除群管理员。</para>
/// <para>接口ID：6995085510524715009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fdelete_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersDeleteManagersResponseDto
{
    /// <summary>
    /// <para>当前群组内，用户类型管理员的用户 ID。ID 类型与查询参数 member_id_type 取值一致（如果 member_id_type 取值 app_id，则当前参数返回的是用户 open_id）。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_managers")]
    public string[]? ChatManagers { get; set; }

    /// <summary>
    /// <para>当前群组内，机器人类型管理员的 App ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_bot_managers")]
    public string[]? ChatBotManagers { get; set; }
}
