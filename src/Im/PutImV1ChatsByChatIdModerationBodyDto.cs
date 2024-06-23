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
/// <para>更新群组的发言权限设置，可设置为全员可发言、仅管理员可发言 或 指定用户可发言。</para>
/// <para>接口ID：6951292665602899970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fupdate</para>
/// </summary>
public record PutImV1ChatsByChatIdModerationBodyDto
{
    /// <summary>
    /// <para>群发言模式（all_members/only_owner/moderator_list，其中 moderator_list 表示部分用户可发言的模式）</para>
    /// <para>必填：否</para>
    /// <para>示例值：moderator_list</para>
    /// </summary>
    [JsonPropertyName("moderation_setting")]
    public string? ModerationSetting { get; set; }

    /// <summary>
    /// <para>选择部分用户可发言模式时，添加的可发言用户列表（自动过滤不在群内的用户）。推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_7d8a6e6df7621556ce0d21922b676706ccs"]</para>
    /// </summary>
    [JsonPropertyName("moderator_added_list")]
    public string[]? ModeratorAddedList { get; set; }

    /// <summary>
    /// <para>选择部分用户可发言模式时，移除的可发言用户列表（自动过滤不在群内的用户）。推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_8d7h6e6df76215566d8dbs92k6767c4d87"]</para>
    /// </summary>
    [JsonPropertyName("moderator_removed_list")]
    public string[]? ModeratorRemovedList { get; set; }
}
