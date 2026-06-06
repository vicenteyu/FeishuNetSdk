// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PutOkrV2ObjectivesByObjectiveIdKeyResultsPositionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改关键结果位置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 修改关键结果位置 请求体
/// <para>通过提供按顺序排列的关键结果 ID 列表，对指定目标下的关键结果进行重新排序，并相应更新其序号。</para>
/// <para>接口ID：7644764969658485708</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective/key_results_position</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective%2fkey_results_position</para>
/// </summary>
public record PutOkrV2ObjectivesByObjectiveIdKeyResultsPositionBodyDto
{
    /// <summary>
    /// <para>关键结果 ID 列表，按照序号顺序。可通过 [获取目标下的所有关键结果] 接口获取。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("key_result_ids")]
    public string[] KeyResultIds { get; set; } = [];
}
