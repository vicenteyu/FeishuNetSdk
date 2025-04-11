// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricTemplatesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标模板列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标模板列表 请求体
/// <para>批量获取指标模板的信息。</para>
/// <para>接口ID：7380276358332710913</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_template%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricTemplatesQueryBodyDto
{
    /// <summary>
    /// <para>指标模板 ID 列表，填写时获取指定的指标模版</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("metrics_template_ids")]
    public string[]? MetricsTemplateIds { get; set; }

    /// <summary>
    /// <para>指标模版状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：to_be_configured</para>
    /// <para>可选值：<list type="bullet">
    /// <item>to_be_configured：待完成配置</item>
    /// <item>to_be_activated：待启用</item>
    /// <item>enabled：已启用</item>
    /// <item>disabled：已停用</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
