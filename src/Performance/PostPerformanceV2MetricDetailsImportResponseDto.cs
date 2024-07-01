// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsImportResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量录入指定周期被评估人的关键指标详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量录入指定周期被评估人的关键指标详情 响应体
/// <para>批量录入指定周期中被评估人的关键指标详情</para>
/// <para>接口ID：7380276358332694529</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_detail/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fimport</para>
/// </summary>
public record PostPerformanceV2MetricDetailsImportResponseDto
{
    /// <summary>
    /// <para>成功时返回导入记录 ID，失败时则为 null</para>
    /// <para>必填：否</para>
    /// <para>示例值：7241404194141224979</para>
    /// </summary>
    [JsonPropertyName("import_record_id")]
    public string? ImportRecordId { get; set; }
}
