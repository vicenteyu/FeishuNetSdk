// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutImV1ChatsByChatIdModerationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新群发言权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群发言权限 请求体
/// <para>更新指定群组的发言权限，可设置为所有群成员可发言、仅群主或管理员可发言、指定群成员可发言。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 如果以用户身份（user_access_token）调用本接口，则该用户必须是群组的群主，才可以更新群发言权限。</para>
/// <para>- 如果以应用身份（tenant_access_token）调用本接口，则该应用机器人需要符合以下任一情况才可以更新群发言权限。</para>
/// <para>- 机器人是群组的群主。</para>
/// <para>- 机器人是群组的创建者、具备==更新应用所创建群的群信息（im:chat:operate_as_owner）== 权限，且仍在群组内。</para>
/// <para>接口ID：6951292665602899970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fupdate</para>
/// </summary>
public record PutImV1ChatsByChatIdModerationBodyDto
{
    /// <summary>
    /// <para>群发言模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- all_members：所有群成员可发言</para>
    /// <para>- only_owner：仅群主或管理员可发言</para>
    /// <para>- moderator_list：指定群成员可发言，取该值时需要选择设置 `moderator_added_list` 和 `moderator_removed_list`</para>
    /// <para>必填：否</para>
    /// <para>示例值：moderator_list</para>
    /// </summary>
    [JsonPropertyName("moderation_setting")]
    public string? ModerationSetting { get; set; }

    /// <summary>
    /// <para>当 `moderation_setting ` 取值为 `moderator_list` 时，以 ID 列表形式添加可发言的用户。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型与查询参数 user_id_type 取值一致，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>- 列表内的用户如果不在群组内，则会被自动过滤掉。</para>
    /// <para>- 请求时，请确保 `moderator_added_list` 和 `moderator_removed_list` 两个参数内的 ID 不重复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_7d8a6e6df7621556ce0d21922b676706ccs"]</para>
    /// </summary>
    [JsonPropertyName("moderator_added_list")]
    public string[]? ModeratorAddedList { get; set; }

    /// <summary>
    /// <para>当 `moderation_setting ` 取值为 `moderator_list` 时，以 ID 列表形式移除可发言的用户。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型与查询参数 user_id_type 取值一致，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>- 列表内的用户如果不在群组内，则会被自动过滤掉。</para>
    /// <para>- 请求时，请确保 `moderator_added_list` 和 `moderator_removed_list` 两个参数内的 ID 不重复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_8d7h6e6df76215566d8dbs92k6767c4d87"]</para>
    /// </summary>
    [JsonPropertyName("moderator_removed_list")]
    public string[]? ModeratorRemovedList { get; set; }
}
