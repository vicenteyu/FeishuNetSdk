// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMessagesGetByCardResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取邮件卡片的邮件列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮件卡片的邮件列表 响应体
/// <para>获取邮件卡片下的邮件列表</para>
/// <para>接口ID：7447350647756800004</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/get_by_card</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message%2fget_by_card</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMessagesGetByCardResponseDto
{
    /// <summary>
    /// <para>邮件Owner信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("owner_info")]
    public UserInfo OwnerInfo { get; set; } = new();

    /// <summary>
    /// <para>邮件Owner信息</para>
    /// </summary>
    public record UserInfo
    {
        /// <summary>
        /// <para>owner是个人邮箱还是公共邮箱</para>
        /// <para>**示例值**：</para>
        /// <para>- `user`：个人邮箱</para>
        /// <para>- `public_mailbox`：公共邮箱</para>
        /// <para>必填：是</para>
        /// <para>示例值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>邮件卡片owner的ID，type为`user`时非空（与`user_id_type`对应）</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad115d62</para>
        /// </summary>
        [JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// <para>公共邮箱唯一标识，type为`public_mailbox`时非空</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonPropertyName("public_mailbox_id")]
        public string? PublicMailboxId { get; set; }
    }

    /// <summary>
    /// <para>邮件ID列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message_ids")]
    public string[] MessageIds { get; set; } = [];

    /// <summary>
    /// <para>邮件卡片ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：512ca581-6059-4449-8150-5522e6646d32</para>
    /// </summary>
    [JsonPropertyName("card_id")]
    public string CardId { get; set; } = string.Empty;
}
