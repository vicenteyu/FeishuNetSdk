// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取标签信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取标签信息 响应体
/// <para>根据指定ID，获取邮件标签信息，包括名称、未读数据、颜色等信息</para>
/// <para>接口ID：7620478754624539580</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-label/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-label%2fget</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdResponseDto
{
    /// <summary>
    /// <para>标签</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("label")]
    public LabelSuffix? Label { get; set; }

    /// <summary>
    /// <para>标签</para>
    /// </summary>
    public record LabelSuffix
    {
        /// <summary>
        /// <para>标签ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7620003644728938013</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>标签名称，最长 255 个字符。支持嵌套标签，嵌套层级之间以 / 分隔（如 a/b/c 表示三级嵌套标签）。创建或更新嵌套标签时，需要传入完整路径（如 a/b/c），不能只传最后一级名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>标签背景颜色，支持以下颜色值：blue、indigo、purple、violet、carmine、red、orange、yellow、lime、green、turquoise、wathet</para>
        /// <para>必填：否</para>
        /// <para>示例值：blue</para>
        /// </summary>
        [JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// <para>带有该标签的未读邮件数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("messages_unread")]
        public int? MessagesUnread { get; set; }
    }
}
