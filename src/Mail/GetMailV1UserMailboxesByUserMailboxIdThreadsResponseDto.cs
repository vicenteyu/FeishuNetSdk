// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdThreadsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出邮件会话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出邮件会话 响应体
/// <para>列出用户指定文件夹或标签下的邮件会话，按时间倒序分页获取</para>
/// <para>接口ID：7626215228942928852</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-thread/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-thread%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdThreadsResponseDto : IPageableResponse<GetMailV1UserMailboxesByUserMailboxIdThreadsResponseDto.Thread>
{
    /// <summary>
    /// <para>会话列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Thread[]? Items { get; set; }

    /// <summary>
    /// <para>会话列表</para>
    /// </summary>
    public record Thread
    {
        /// <summary>
        /// <para>会话ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：xx</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会话内的最新的一封邮件摘要，用于快速预览邮件核心内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：hello world</para>
        /// </summary>
        [JsonPropertyName("body_preview")]
        public string? BodyPreview { get; set; }
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
