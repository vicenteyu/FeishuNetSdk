// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteImV1ChatsByChatIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将用户或机器人移出群聊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人移出群聊 响应体
/// <para>将指定的用户或机器人从群聊中移出。</para>
/// <para>## 前提条件</para>
/// <para>调用该接口的应用，需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 仅群主、群管理员，或者是创建群组且具有 **更新应用所创建群的群信息（im:chat:operate_as_owner）** 权限的机器人，可以将其他群成员移出群组。</para>
/// <para>- 用户或机器人在任何条件下均可将自己移出群组（即主动退群）。</para>
/// <para>- 每次请求，最多移除 50 个用户或者 5 个机器人。</para>
/// <para>- 操作内部群时，操作者须与群组在同一租户下。</para>
/// <para>接口ID：6946222929790468124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fdelete</para>
/// </summary>
public record DeleteImV1ChatsByChatIdMembersResponseDto
{
    /// <summary>
    /// <para>无效成员列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_id_list")]
    public string[]? InvalidIdList { get; set; }
}
