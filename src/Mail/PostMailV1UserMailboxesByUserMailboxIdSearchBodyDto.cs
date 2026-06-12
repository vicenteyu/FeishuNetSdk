// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 搜索邮件 请求体
/// <para>搜索用户当前账户下的邮件</para>
/// <para>接口ID：7648865505080429801</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fsearch</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词。</para>
    /// <para>**数据校验规则：**</para>
    /// <para>- 长度范围：0 ～ 50 字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：合同审批通知</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>用于对搜索结果进行精细化筛选，支持按发件人、收件人、文件夹、时间范围等多维度组合过滤，缩小查询范围，提升搜索精准度。</para>
    /// <para>**示例值：** {"from":["user@example.com"],"is_unread":true}</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public MailSearchFilter? Filter { get; set; }

    /// <summary>
    /// <para>用于对搜索结果进行精细化筛选，支持按发件人、收件人、文件夹、时间范围等多维度组合过滤，缩小查询范围，提升搜索精准度。</para>
    /// <para>**示例值：** {"from":["user@example.com"],"is_unread":true}</para>
    /// </summary>
    public record MailSearchFilter
    {
        /// <summary>
        /// <para>发件人姓名或邮箱地址筛选，仅返回来自该发件人的邮件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("from")]
        public string[]? From { get; set; }

        /// <summary>
        /// <para>收件人姓名或邮箱地址筛选，仅返回收件人列表包含该收件人的邮件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("to")]
        public string[]? To { get; set; }

        /// <summary>
        /// <para>抄送人姓名或邮箱地址筛选，仅返回抄送人列表包含该抄送人的邮件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("cc")]
        public string[]? Cc { get; set; }

        /// <summary>
        /// <para>密送人姓名或邮箱地址筛选，仅返回秘送人列表包含该秘送人的邮件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("bcc")]
        public string[]? Bcc { get; set; }

        /// <summary>
        /// <para>邮件主题搜索，仅返回主题中能搜到搜索词的结果。</para>
        /// <para>必填：否</para>
        /// <para>示例值：合同签署</para>
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// <para>文件夹名称筛选，仅返回在所选目录下的邮件。仅支持传入系统文件夹名称（固定值 inbox/sent/draft/trash/spam/archive/priority/flagged/other/scheduled，其中，priority指重要邮件）、自定义文件夹名称。子文件夹需使用 parent_name/child_name格式，可通过 folder list 接口查看文件夹名称。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("folder")]
        public string[]? Folder { get; set; }

        /// <summary>
        /// <para>自定义标签名称筛选，仅返回包含指定自定义标签的邮件。子标签需使用parent_name/child_name 格式，可通过 label list 接口查看标签名称。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("label")]
        public string[]? Label { get; set; }

        /// <summary>
        /// <para>是否只筛选有附件的邮件，默认值：**否**</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_attachment")]
        public bool? HasAttachment { get; set; }

        /// <summary>
        /// <para>是否只筛选未读邮件，默认为**否**</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_unread")]
        public bool? IsUnread { get; set; }

        /// <summary>
        /// <para>邮件接收时间范围筛选，只返回在所选时间范围内的邮件。</para>
        /// <para>限制：一次搜索请求的时间范围不要超过1年。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public TimeRange? CreateTime { get; set; }

        /// <summary>
        /// <para>邮件接收时间范围筛选，只返回在所选时间范围内的邮件。</para>
        /// <para>限制：一次搜索请求的时间范围不要超过1年。</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>时间范围的开始时间。（iso8601）精确到秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-10T00:00:00+08:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>时间范围的截止时间。（iso8601）精确到秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-10T00:00:00+08:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }
    }
}
