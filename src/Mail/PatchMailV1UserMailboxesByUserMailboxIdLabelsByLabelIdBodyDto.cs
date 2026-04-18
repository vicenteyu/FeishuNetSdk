// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PatchMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 更新标签 请求体
/// <para>更新用户指定标签的名字、颜色等信息</para>
/// <para>接口ID：7620478754624392124</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-label/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-label%2fpatch</para>
/// </summary>
public record PatchMailV1UserMailboxesByUserMailboxIdLabelsByLabelIdBodyDto
{
    /// <summary>
    /// <para>邮件标签，必须填写名字或颜色中的至少一个字段</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("label")]
    public LabelSuffix Label { get; set; } = new();

    /// <summary>
    /// <para>邮件标签，必须填写名字或颜色中的至少一个字段</para>
    /// </summary>
    public record LabelSuffix
    {
        /// <summary>
        /// <para>标签名称，可选填写。最长255个字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>标签背景颜色，可选填写。支持以下颜色值：blue、indigo、purple、violet、carmine、red、orange、yellow、lime、green、turquoise、wathet</para>
        /// <para>必填：否</para>
        /// <para>示例值：blue</para>
        /// </summary>
        [JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }
    }
}
