// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdLabelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建标签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建标签 请求体
/// <para>根据用户指定的名称、颜色等信息，创建邮件标签</para>
/// <para>接口ID：7620478754624555964</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-label/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-label%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdLabelsBodyDto
{
    /// <summary>
    /// <para>邮件标签，必须填写标签名称，可选填写背景颜色</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("label")]
    public LabelSuffix Label { get; set; } = new();

    /// <summary>
    /// <para>邮件标签，必须填写标签名称，可选填写背景颜色</para>
    /// </summary>
    public record LabelSuffix
    {
        /// <summary>
        /// <para>标签名称，必须填写。最长255个字符。</para>
        /// <para>必填：是</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>标签背景颜色，支持以下颜色值：blue、indigo、purple、violet、carmine、red、orange、yellow、lime、green、turquoise、wathet</para>
        /// <para>必填：否</para>
        /// <para>示例值：blue</para>
        /// </summary>
        [JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }
    }
}
