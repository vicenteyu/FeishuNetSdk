// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostPerformanceV2MetricLibsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标列表 请求体
/// <para>获取指标库中的指标信息，如指标名称、指标类型、指标标签和指标字段等信息。可通过指标启用状态、指标类型、指标可用范围等筛选条件获取指定范围的指标信息。</para>
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_lib/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricLibsQueryBodyDto
{
    /// <summary>
    /// <para>指标启用状态，填写时根据指定启用状态进行筛选</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// <para>指标标签 ID 列表，可通过[获取指标标签信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_tag/list)接口获取，填写时筛选拥有指定标签的指标</para>
    /// <para>必填：否</para>
    /// <para>最大长度：99</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public string[]? TagIds { get; set; }

    /// <summary>
    /// <para>指标类型 ID 列表，可通过[获取指标模板列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_template/query)</para>
    /// <para>接口返回结果中的 `data.items.metrics.type_id` 获取，填写时根据指定的指标类型进行筛选</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type_ids")]
    public string[]? TypeIds { get; set; }

    /// <summary>
    /// <para>指标可用范围，填写时根据指定可用范围进行筛选</para>
    /// <para>必填：否</para>
    /// <para>示例值：admins_and_reviewees</para>
    /// <para>可选值：<list type="bullet">
    /// <item>admins_and_reviewees：允许管理员下发和被评估人选用</item>
    /// <item>only_admins：仅允许管理员下发</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("range_of_availability")]
    public string? RangeOfAvailability { get; set; }

    /// <summary>
    /// <para>指标评分类型，填写时根据指定评分类型进行筛选</para>
    /// <para>必填：否</para>
    /// <para>示例值：score_manually</para>
    /// <para>可选值：<list type="bullet">
    /// <item>score_manually：手动评分</item>
    /// <item>score_by_formula：公式评分</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scoring_setting_type")]
    public string? ScoringSettingType { get; set; }
}
