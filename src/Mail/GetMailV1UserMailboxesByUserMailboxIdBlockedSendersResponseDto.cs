// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdBlockedSendersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取拦截发件人列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取拦截发件人列表 响应体
/// <para>获取指定用户邮箱的拦截发件人名单，支持分页查询。</para>
/// <para>接口ID：7695747058686905557</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdBlockedSendersResponseDto : IPageableResponse<GetMailV1UserMailboxesByUserMailboxIdBlockedSendersResponseDto.UserSenderRecord>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1710000000</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>用户级黑名单条目列表，按创建时间倒序</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public UserSenderRecord[]? Items { get; set; }

    /// <summary>
    /// <para>用户级黑名单条目列表，按创建时间倒序</para>
    /// </summary>
    public record UserSenderRecord
    {
        /// <summary>
        /// <para>发件人地址或域名，与创建时的 sender 取值一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：marketing@example.com</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public string? Sender { get; set; }
    }
}
