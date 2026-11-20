// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建拦截发件人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量创建拦截发件人 响应体
/// <para>批量将发件人加入指定用户邮箱的拦截发件人名单。支持按完整邮箱地址或邮箱域名添加，单次最多 100 项。</para>
/// <para>接口ID：7695747058686971093</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-blocked_sender/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-blocked_sender%2fbatch_create</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdBlockedSendersBatchCreateResponseDto
{
    /// <summary>
    /// <para>部分失败的发件人列表。每项含 sender 与 reason_code（INVALID/SELF_ADDRESS/SELF_DOMAIN/CONFLICT_BLOCK/QUOTA_EXCEEDED）。空列表表示全部成功</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_items")]
    public UserSenderFailedItem[]? FailedItems { get; set; }

    /// <summary>
    /// <para>部分失败的发件人列表。每项含 sender 与 reason_code（INVALID/SELF_ADDRESS/SELF_DOMAIN/CONFLICT_BLOCK/QUOTA_EXCEEDED）。空列表表示全部成功</para>
    /// </summary>
    public record UserSenderFailedItem
    {
        /// <summary>
        /// <para>失败的发件人地址或域名，与请求 items[].sender 一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：bad-format</para>
        /// </summary>
        [JsonPropertyName("sender")]
        public string? Sender { get; set; }

        /// <summary>
        /// <para>失败原因码：</para>
        /// <para>- INVALID 非法发件人格式</para>
        /// <para>- SELF_ADDRESS 不能屏蔽/信任自己的邮箱地址</para>
        /// <para>- SELF_DOMAIN 不能屏蔽/信任自己邮箱所在域</para>
        /// <para>- CONFLICT_BLOCK 与对侧名单冲突（黑白互斥）</para>
        /// <para>- QUOTA_EXCEEDED 超过单用户黑白名单合计配额</para>
        /// <para>必填：否</para>
        /// <para>示例值：INVALID</para>
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string? ReasonCode { get; set; }
    }
}
