// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV1JobLevelsByJobLevelIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新单个职级 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新单个职级 请求体
/// <para>该接口可以通过职级ID更新单个职级信息，包括职级数值、名称等信息。</para>
/// <para>接口ID：7072714700206768130</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2fpatch</para>
/// </summary>
public record PatchCorehrV1JobLevelsByJobLevelIdBodyDto
{
    /// <summary>
    /// <para>职级数值，该字段主要用来在职级大小排序，职级的数值越大，代表职级越高</para>
    /// <para>- 如果不填该字段则不更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：9999</para>
    /// </summary>
    [JsonPropertyName("level_order")]
    public int? LevelOrder { get; set; }

    /// <summary>
    /// <para>职级编码。非必填字段，如果非空值会校验全局唯一性，如果传空值则不参与全局校验。</para>
    /// <para>必填：否</para>
    /// <para>示例值：VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>职级名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[]? Names { get; set; }

    /// <summary>
    /// <para>职级名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言，中文用zh-CN，英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称信息的内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：高级工程师</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>自定义字段（该字段暂时不支持）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（该字段暂时不支持）</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，具体传值方式参见[获取自定义字段的元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
