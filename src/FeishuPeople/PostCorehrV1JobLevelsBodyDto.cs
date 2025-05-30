// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PostCorehrV1JobLevelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建职级 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 新建职级 请求体
/// <para>使用指定信息创建职级信息，每次调用支持创建1个职级对象，接口内会做相关规则校验。</para>
/// <para>接口ID：7017707615191154691</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2fcreate</para>
/// </summary>
public record PostCorehrV1JobLevelsBodyDto
{
    /// <summary>
    /// <para>职级数值，该字段主要用来在职级大小排序，职级的数值越大，代表职级越高</para>
    /// <para>必填：是</para>
    /// <para>示例值：9999</para>
    /// </summary>
    [JsonPropertyName("level_order")]
    public int LevelOrder { get; set; }

    /// <summary>
    /// <para>职级编码。非必填字段，如果非空值会校验全局唯一性，如果传空值则不参与全局校验。</para>
    /// <para>必填：否</para>
    /// <para>示例值：VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>职级名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

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
        /// <para>名称信息的内容。</para>
        /// <para>- 职级中英文名称会有全局唯一校验</para>
        /// <para>- 名称不能包含「/」「；」「;」字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：初级工程师</para>
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
    /// <para>是否启用，true为启用，false为停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>自定义字段（目前职级暂不支持该功能）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（目前职级暂不支持该功能）</para>
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
        /// <para>字段值，为 JSON 转义后的字符串。</para>
        /// <para>**注意：具体传值方式参见**[获取自定义字段的元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>职等 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_grade")]
    public string[]? JobGrade { get; set; }

    /// <summary>
    /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pathway_ids")]
    public string[]? PathwayIds { get; set; }
}
