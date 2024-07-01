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
// <summary>获取评估项配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取评估项配置 请求体
/// <para>获取评估项配置信息，包括评估题名称、评估项类型、评估等级配置等</para>
/// <para>接口ID：7351374599659798532</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/indicator/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2findicator%2fquery</para>
/// </summary>
public record PostPerformanceV2IndicatorsQueryBodyDto
{
    /// <summary>
    /// <para>评估项 ID 列表，获取指定评估题的配置数据。如果不传则返回所有</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("indicator_ids")]
    public string[]? IndicatorIds { get; set; }
}
