// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取被评估人关键指标结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取被评估人关键指标结果 请求体
/// <para>批量获取指定周期中被评估人的关键指标结果。</para>
/// <para>接口ID：7380276358332743681</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricDetailsQueryBodyDto
{
    /// <summary>
    /// <para>周期 ID，1 次只允许查询 1 个周期，semester_id 可通过【[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)】接口获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6992035450862224940</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string SemesterId { get; set; } = string.Empty;

    /// <summary>
    /// <para>被评估人 ID 列表，与入参 `user_id_type` 类型一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("reviewee_user_ids")]
    public string[] RevieweeUserIds { get; set; } = Array.Empty<string>();
}
