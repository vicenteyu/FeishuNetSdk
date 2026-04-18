// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdDraftsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出草稿列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出草稿列表 响应体
/// <para>列出用户草稿箱中的草稿，只会返回草稿ID信息，不会返回草稿内容</para>
/// <para>接口ID：7620478754624474044</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-draft/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-draft%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdDraftsResponseDto : IPageableResponse<GetMailV1UserMailboxesByUserMailboxIdDraftsResponseDto.Draft>
{
    /// <summary>
    /// <para>草稿列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Draft[]? Items { get; set; }

    /// <summary>
    /// <para>草稿列表</para>
    /// </summary>
    public record Draft
    {
        /// <summary>
        /// <para>草稿ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：268dce11-85f7-427d-8756-6be3abc850fd</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
