// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdTemplatesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出邮件模板 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出邮件模板 响应体
/// <para>列出指定用户邮箱下的全部个人邮件模板基本信息（一次性返回，不分页），常用于在编辑或发送邮件场景下展示可选模板列表。如需获取模板正文与附件等完整字段，请通过获取个人邮件模板详情接口按 `template_id` 查询。</para>
/// <para>接口ID：7636620599011920847</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-template/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-template%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdTemplatesResponseDto
{
    /// <summary>
    /// <para>个人邮件模板列表。每个模板对象仅填充以下字段；如需获取完整模板内容，请通过获取个人邮件模板详情接口按 `template_id` 查询。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Item[]? Items { get; set; }

    /// <summary>
    /// <para>个人邮件模板列表。每个模板对象仅填充以下字段；如需获取完整模板内容，请通过获取个人邮件模板详情接口按 `template_id` 查询。</para>
    /// </summary>
    public record Item
    {
        /// <summary>
        /// <para>模板 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7281187859195772947</para>
        /// </summary>
        [JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// <para>模板名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：销售跟进模板</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>模板创建时间（毫秒级时间戳字符串）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1716279320000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }
}
