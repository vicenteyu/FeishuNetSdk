// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出邮箱联系人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出邮箱联系人 响应体
/// <para>列出邮箱联系人列表</para>
/// <para>接口ID：7270360193791918081</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-mail_contact/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-mail_contact%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto : IPageableResponse<GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto.MailContact>
{
    /// <summary>
    /// <para>邮件联系人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MailContact[]? Items { get; set; }

    /// <summary>
    /// <para>邮件联系人列表</para>
    /// </summary>
    public record MailContact
    {
        /// <summary>
        /// <para>联系人 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7256274576546463764</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>联系人姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>联系人公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三科技有限公司</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// <para>联系人手机号</para>
        /// <para>必填：否</para>
        /// <para>示例值：19912341234</para>
        /// <para>最大长度：40</para>
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// <para>联系人邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@example.com</para>
        /// <para>最大长度：319</para>
        /// </summary>
        [JsonPropertyName("mail_address")]
        public string? MailAddress { get; set; }

        /// <summary>
        /// <para>联系人标签</para>
        /// <para>必填：否</para>
        /// <para>示例值：朋友</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// <para>联系人备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书发布会认识</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// <para>联系人头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://exampeimg.com/xxxx.jpg</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>联系人职位</para>
        /// <para>必填：否</para>
        /// <para>示例值：CEO</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonPropertyName("position")]
        public string? Position { get; set; }
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
