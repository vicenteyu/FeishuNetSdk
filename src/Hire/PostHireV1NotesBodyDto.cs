// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostHireV1NotesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建备注 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建备注 请求体
/// <para>为人才创建备注信息，支持在备注中@其他用户。</para>
/// <para>接口ID：6950213983267274756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fcreate</para>
/// </summary>
public record PostHireV1NotesBodyDto
{
    /// <summary>
    /// <para>人才ID，可通过[获取人才列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6916472453069883661</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string TalentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>投递ID，可通过[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891565253964859661</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>创建人ID，请传入与`user_id_type`相匹配的ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }

    /// <summary>
    /// <para>备注内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：这是一个备注</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>备注私密属性（默认为公开）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：私密</item>
    /// <item>2：公开</item>
    /// </list></para>
    /// <para>默认值：2</para>
    /// </summary>
    [JsonPropertyName("privacy")]
    public int? Privacy { get; set; }

    /// <summary>
    /// <para>是否通知被@的用户</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("notify_mentioned_user")]
    public bool? NotifyMentionedUser { get; set; }

    /// <summary>
    /// <para>被@用户列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mention_entity_list")]
    public MentionEntity[]? MentionEntityLists { get; set; }

    /// <summary>
    /// <para>被@用户列表</para>
    /// </summary>
    public record MentionEntity
    {
        /// <summary>
        /// <para>被@用户在 content 中的偏移量</para>
        /// <para>- 取值范围：0 ~ content.length</para>
        /// <para>必填：是</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// <para>被@用户的 ID，请传入与 `user_id_type` 类型相匹配的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
