// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetDocxV1ChatsByChatIdAnnouncementResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群公告基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取群公告基本信息 响应体
/// <para>获取指定群组中的群公告基本信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的群组内。</para>
/// <para>- 获取内部群信息时，调用当前接口的用户或者机器人必须与对应群组在同一租户下。</para>
/// <para>接口ID：7450053428095615004</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/chat-announcement/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement%2fget</para>
/// </summary>
public record GetDocxV1ChatsByChatIdAnnouncementResponseDto
{
    /// <summary>
    /// <para>群公告当前版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("revision_id")]
    public int? RevisionId { get; set; }

    /// <summary>
    /// <para>群公告生成的时间戳（秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>群公告更新的时间戳（秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1609296809</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// <para>群公告所有者 ID，ID 值与 owner_id_type 中的ID类型对应</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>群公告所有者的 ID 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：user_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</item>
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("owner_id_type")]
    public string? OwnerIdType { get; set; }

    /// <summary>
    /// <para>群公告最新修改者 ID，ID 值与 modifier_id_type 中的ID类型对应</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
    /// </summary>
    [JsonPropertyName("modifier_id")]
    public string? ModifierId { get; set; }

    /// <summary>
    /// <para>群公告最新修改者 ID 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：user_id</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user_id：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。</item>
    /// <item>union_id：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。</item>
    /// <item>open_id：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("modifier_id_type")]
    public string? ModifierIdType { get; set; }

    /// <summary>
    /// <para>群公告类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：新版本群公告</item>
    /// <item>doc：旧版本群公告</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("announcement_type")]
    public string? AnnouncementType { get; set; }
}
