// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PutOkrV2ObjectivesByObjectiveIdKeyResultsWeightBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改关键结果权重 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 修改关键结果权重 请求体
/// <para>调整指定目标下各关键结果的权重分配。为每个关键结果设置权重值，以反映其在计算目标整体得分时的相对重要性。</para>
/// <para>接口ID：7644764969658502092</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective/key_results_weight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective%2fkey_results_weight</para>
/// </summary>
public record PutOkrV2ObjectivesByObjectiveIdKeyResultsWeightBodyDto
{
    /// <summary>
    /// <para>关键结果权重列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("key_result_weights")]
    public KeyResultWeight[] KeyResultWeights { get; set; } = [];

    /// <summary>
    /// <para>关键结果权重列表</para>
    /// </summary>
    public record KeyResultWeight
    {
        /// <summary>
        /// <para>关键结果 ID，可通过 [获取目标下的所有关键结果] 接口获取。</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("key_result_id")]
        public string KeyResultId { get; set; } = string.Empty;

        /// <summary>
        /// <para>目标的权重：[0,1]，支持三位小数</para>
        /// <para>必填：是</para>
        /// <para>示例值：0.5</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("weight")]
        public double Weight { get; set; }
    }
}
