// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="PatchCorehrV2LocationsByLocationIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新地点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新地点 请求体
/// <para>更新地点</para>
/// <para>接口ID：7420421437192962051</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fpatch</para>
/// </summary>
public record PatchCorehrV2LocationsByLocationIdBodyDto
{
    /// <summary>
    /// <para>上级地点，在创建场景下，该字段必填，枚举值及详细信息可通过[【批量分页查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719168654814483759</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>地点名称</para>
    /// <para>- 名称不能包含「/」「；」「;」「\」「'」字符</para>
    /// <para>- 地点中英文名称会有全局唯一校验</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("names")]
    public I18n[]? Names { get; set; }

    /// <summary>
    /// <para>地点名称</para>
    /// <para>- 名称不能包含「/」「；」「;」「\」「'」字符</para>
    /// <para>- 地点中英文名称会有全局唯一校验</para>
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
        /// <para>名称内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：中文示例</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>地点启用/停用状态</para>
    /// <para>- true 为启用</para>
    /// <para>- false 为停用</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// <para>版本生效日期</para>
    /// <para>- 填写格式：YYYY-MM-DD</para>
    /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
    /// <para>- 该接口只支持到最小单位为日</para>
    /// <para>- 日期范围要求:1900-01-01～9999-12-31</para>
    /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-02</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>地点编码 (不能与其他记录的编码重复)，当开启自动编码时，该字段会失效</para>
    /// <para>必填：否</para>
    /// <para>示例值：12456</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>地点描述</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("descriptions")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>地点用途 ID，枚举值及详细信息可通过[【批量查询地点用途】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
    /// <para>- 请求参数object_api_name=location；custom_api_name=location_usage</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("location_usages")]
    public Enum[]? LocationUsages { get; set; }

    /// <summary>
    /// <para>地点用途 ID，枚举值及详细信息可通过[【批量查询地点用途】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
    /// <para>- 请求参数object_api_name=location；custom_api_name=location_usage</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：phone_type</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：4690238309151997779</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>区域设置 ID ，枚举值及详细信息可通过[【批量查询枚举信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询获得。</para>
    /// <para>- 请求参数object_api_name=location；custom_api_name=locale</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh_cn</para>
    /// </summary>
    [JsonPropertyName("locale")]
    public Enum? Locale { get; set; }

    /// <summary>
    /// <para>时区 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("time_zone_id")]
    public string? TimeZoneId { get; set; }

    /// <summary>
    /// <para>默认显示语言 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("display_language_id")]
    public string? DisplayLanguageId { get; set; }
}
