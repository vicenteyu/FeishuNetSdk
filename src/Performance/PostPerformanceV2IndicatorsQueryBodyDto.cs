// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2IndicatorsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取评估项列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取评估项列表 请求体
/// <para>批量获取评估项信息，如评估项名称、评估项类型、评估项等级配置等信息。</para>
/// <para>接口ID：7351374599659798532</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2findicator%2fquery</para>
/// </summary>
public record PostPerformanceV2IndicatorsQueryBodyDto
{
    /// <summary>
    /// <para>评估项 ID 列表，填写时获取指定的评估项，不填时返回所有评估项</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("indicator_ids")]
    public string[]? IndicatorIds { get; set; }
}
