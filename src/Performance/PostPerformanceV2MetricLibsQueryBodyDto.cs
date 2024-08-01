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
// <summary>获取指标库信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标库信息 请求体
/// <para>获取指标库的信息</para>
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_lib/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricLibsQueryBodyDto
{
    /// <summary>
    /// <para>状态是否为启用，不指定获取所有状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// <para>指标所属的标签 ID，可通过【[获取指标标签信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_tag/list)】接口获取，不指定获取所有标签</para>
    /// <para>必填：否</para>
    /// <para>最大长度：99</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("tag_ids")]
    public string[]? TagIds { get; set; }

    /// <summary>
    /// <para>所属的指标类型 ID，不指定获取所有类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type_ids")]
    public string[]? TypeIds { get; set; }

    /// <summary>
    /// <para>可用范围，不指定获取所有范围</para>
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
    /// <para>评分设置类型，不指定获取所有类型</para>
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
