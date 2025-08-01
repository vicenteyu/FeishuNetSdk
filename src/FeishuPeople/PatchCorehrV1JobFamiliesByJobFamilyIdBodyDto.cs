// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PatchCorehrV1JobFamiliesByJobFamilyIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新序列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新序列 请求体
/// <para>可以通过序列ID更新单个序列详情信息，例如序列名称、上级序列ID等。</para>
/// <para>接口ID：7072646533586927644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2fpatch</para>
/// </summary>
public record PatchCorehrV1JobFamiliesByJobFamilyIdBodyDto
{
    /// <summary>
    /// <para>序列名称。不传值时默认不更新此字段，保持原值</para>
    /// <para>- 包含lang（语言）和value（序列名称）两个子参数，更新时需同时提供</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[]? Names { get; set; }

    /// <summary>
    /// <para>序列名称。不传值时默认不更新此字段，保持原值</para>
    /// <para>- 包含lang（语言）和value（序列名称）两个子参数，更新时需同时提供</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>语言信息，中文用zh-CN，英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>序列名称。最小1字符，最大200字符</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 序列中英文名称会有全局唯一校验</para>
        /// <para>- 语言需与lang参数的取值一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：研发序列</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否启用，true为启用，false为停用。不传值时默认不更新此字段，保持原值</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>是否可被使用，true为可被使用，false为不可被使用。不传值时默认不更新此字段，保持原值</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("selectable")]
    public bool? Selectable { get; set; }

    /// <summary>
    /// <para>上级序列ID。不传值时默认不更新此字段，保持原值。</para>
    /// <para>- ID获取方式：调用[【新建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【查询租户的序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：4698020757495316313</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>通道ID，不传值时默认不更新此字段，保持原值。</para>
    /// <para>- 详情可以参考[获取通道信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pathway_ids")]
    public string[]? PathwayIds { get; set; }

    /// <summary>
    /// <para>版本生效日期。不传值时默认不更新此字段，保持原值</para>
    /// <para>- 填写格式：YYYY-MM-DD 00:00:00（系统会自动将时分秒改为00:00:00）</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string? EffectiveTime { get; set; }

    /// <summary>
    /// <para>序列编码 (不能与其他记录的编码重复)。不传值时默认不更新此字段，保持原值。</para>
    /// <para>- 开启自动编码时，如果不传值会自动生成编码，否则以传入值为准</para>
    /// <para>- 未开启自动编码时，不传值不会自动生成编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：123456</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>描述。不传值时默认不更新此字段，保持原值。</para>
    /// <para>- 包含lang（语言）和value（序列名称）两个子参数，更新时需同时提供</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>自定义字段（该字段暂时不支持），注意事项：</para>
    /// <para>- 包含field_name（字段名）和value（字段值）两个子参数，更新时需同时提供</para>
    /// <para>- 不传值时默认不更新此字段，保持原值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（该字段暂时不支持），注意事项：</para>
    /// <para>- 包含field_name（字段名）和value（字段值）两个子参数，更新时需同时提供</para>
    /// <para>- 不传值时默认不更新此字段，保持原值</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>自定义字段 API Name，即自定义字段的唯一标识</para>
        /// <para>- 最小1字符，最大200字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>- 最小1字符，最大200字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
