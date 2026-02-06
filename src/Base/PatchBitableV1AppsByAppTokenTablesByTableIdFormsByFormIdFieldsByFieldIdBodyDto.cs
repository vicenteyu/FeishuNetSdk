// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新表单问题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新表单问题 请求体
/// <para>更新表单中的问题项。</para>
/// <para>接口ID：7112628058154893314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form-field%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdFieldsByFieldIdBodyDto
{
    /// <summary>
    /// <para>要更新的表单问题的前一个表单问题的 `field_id`，用于更新当前表单问题的位置。若该字段为空字符串，则表示将该表单问题的顺序排至首个位置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldjX7dUj5</para>
    /// </summary>
    [JsonPropertyName("pre_field_id")]
    public string? PreFieldId { get; set; }

    /// <summary>
    /// <para>表单问题</para>
    /// <para>必填：否</para>
    /// <para>示例值：任务名称</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>问题描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：请概述该任务</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>该问题是否必填。可选值：</para>
    /// <para>- true：必填</para>
    /// <para>- false：非必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// <para>该问题是否可见。当值为 false 时，不允许更新其他字段。可选值：</para>
    /// <para>- true：可见</para>
    /// <para>- false：不可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// <para>富文本描述</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("rich_description")]
    public AppRichDescriptionSegment[]? RichDescriptions { get; set; }

    /// <summary>
    /// <para>富文本描述</para>
    /// </summary>
    public record AppRichDescriptionSegment
    {
        /// <summary>
        /// <para>元素类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：text</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>text：纯文本</item>
        /// <item>url：链接</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("segment_type")]
        public string SegmentType { get; set; } = string.Empty;

        /// <summary>
        /// <para>文本值</para>
        /// <para>必填：是</para>
        /// <para>示例值：这是一个开放性问题</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// <para>链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.larkoffice.com/</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }
    }
}
