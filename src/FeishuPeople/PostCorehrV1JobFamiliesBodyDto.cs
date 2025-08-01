// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PostCorehrV1JobFamiliesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建序列 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建序列 请求体
/// <para>该接口用于创建单个序列，创建后系统中新增一条包含序列编码、名称、描述等信息的序列记录</para>
/// <para>接口ID：7017707615190925315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2fcreate</para>
/// </summary>
public record PostCorehrV1JobFamiliesBodyDto
{
    /// <summary>
    /// <para>序列名称</para>
    /// <para>- 每个name元素必须包含lang和value参数，表明对应语言下具体的name值</para>
    /// <para>- 目前name最大元素个数为2，仅支持中、英文</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>序列名称</para>
    /// <para>- 每个name元素必须包含lang和value参数，表明对应语言下具体的name值</para>
    /// <para>- 目前name最大元素个数为2，仅支持中、英文</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言，中文用zh-CN，英文用en-US</para>
        /// <para>- 必须与 value 字段同时传入</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称信息的内容，注意事项：</para>
        /// <para>- 名称不能包含「/」「；」「;」字符</para>
        /// <para>- 序列中英文名称会有全局唯一校验</para>
        /// <para>- 最小1字符，最大200字符</para>
        /// <para>- 必须与 lang 字段同时传入</para>
        /// <para>必填：是</para>
        /// <para>示例值：技术</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否启用，true为启用，false为停用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>是否可被使用，true为可被使用，false为不可被使用。默认值为true，代表可被使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("selectable")]
    public bool? Selectable { get; set; }

    /// <summary>
    /// <para>上级序列 ID。ID获取方式：</para>
    /// <para>- 调用[【新建序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/create)[【查询租户的序列信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)等接口可以返回序列ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：4698020757495316313</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)。默认值为空数组，表示不关联任何通道</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pathway_ids")]
    public string[]? PathwayIds { get; set; }

    /// <summary>
    /// <para>版本生效日期。注意事项：</para>
    /// <para>- 填写格式：YYYY-MM-DD 00:00:00（系统会自动将时分秒改为00:00:00）</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
    /// <para>- 最小19字符（格式为YYYY-MM-DD 00:00:00），最大19字符</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>编码 (不能与其他记录的编码重复)，当开启自动编码时，该字段会失效</para>
    /// <para>必填：否</para>
    /// <para>示例值：123456</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>描述。默认值为空数组，表示没有描述</para>
    /// <para>- 每个description元素必须包含lang和value参数，表明对应语言下具体的描述值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>自定义字段（序列暂时不支持自定义字段），格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块。默认值为空数组，表示没有自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（序列暂时不支持自定义字段），格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块。默认值为空数组，表示没有自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>- 最少1个字符，最多200个字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>- 自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// <para>- 最少1个字符，最多200个字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
