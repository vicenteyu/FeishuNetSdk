// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PatchHireV1NotesByNoteIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新备注 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新备注 请求体
/// <para>根据备注 ID 更新备注信息。</para>
/// <para>接口ID：6950644745484402715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fpatch</para>
/// </summary>
public record PatchHireV1NotesByNoteIdBodyDto
{
    /// <summary>
    /// <para>备注内容</para>
    /// <para>必填：是</para>
    /// <para>示例值：这是一个备注</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>更新人 ID，请传入与`user_id_type`相匹配的ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>是否通知被@的用户</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
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
        /// <para>必填：是</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// <para>被@人的 user id，请传入与`user_id_type`相匹配的ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
