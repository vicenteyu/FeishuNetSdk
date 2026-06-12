// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索邮件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 搜索邮件 响应体
/// <para>搜索用户当前账户下的邮件</para>
/// <para>接口ID：7648865505080429801</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fsearch</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto : IPageableResponse<PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto.MailSearchItem>
{
    /// <summary>
    /// <para>搜索结果列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MailSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>搜索结果列表</para>
    /// </summary>
    public record MailSearchItem
    {
        /// <summary>
        /// <para>邮件唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：msg_XXX</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含邮件基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>邮件元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public MailSearchMeta? MetaData { get; set; }

        /// <summary>
        /// <para>邮件元信息</para>
        /// </summary>
        public record MailSearchMeta
        {
            /// <summary>
            /// <para>邮件主题</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试邮件</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>邮件线程 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：thread_id_XXX</para>
            /// </summary>
            [JsonPropertyName("thread_id")]
            public string? ThreadId { get; set; }

            /// <summary>
            /// <para>邮件接收时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-15T14:30:00+08:00</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>邮件唯一标识</para>
            /// <para>必填：否</para>
            /// <para>示例值：msg_id_xxx</para>
            /// </summary>
            [JsonPropertyName("message_biz_id")]
            public string? MessageBizId { get; set; }

            /// <summary>
            /// <para>邮件发件人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("from")]
            public MailAddress? From { get; set; }

            /// <summary>
            /// <para>邮件发件人</para>
            /// </summary>
            public record MailAddress
            {
                /// <summary>
                /// <para>邮件地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：mike@outlook.com</para>
                /// </summary>
                [JsonPropertyName("mail_address")]
                public string MailAddressSuffix { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Mike</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>搜索命中结果数</para>
    /// <para>必填：否</para>
    /// <para>示例值：99</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>搜索补充提示信息，返回本次搜索的额外说明，例如：query被截断；搜索结果不全 等</para>
    /// <para>必填：否</para>
    /// <para>示例值：The query is too long and has been truncated to the first 50 characters for search.</para>
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }
}
