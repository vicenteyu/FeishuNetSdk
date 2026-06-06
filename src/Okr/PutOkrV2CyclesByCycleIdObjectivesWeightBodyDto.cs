// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PutOkrV2CyclesByCycleIdObjectivesWeightBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改 OKR 目标权重 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 修改 OKR 目标权重 请求体
/// <para>批量修改指定 OKR 周期下多个目标的权重。权重取值范围为 0 到 1，支持最多三位小数。</para>
/// <para>接口ID：7644764969658338252</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle/objectives_weight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle%2fobjectives_weight</para>
/// </summary>
public record PutOkrV2CyclesByCycleIdObjectivesWeightBodyDto
{
    /// <summary>
    /// <para>目标权重列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("objective_weights")]
    public ObjectiveWeight[] ObjectiveWeights { get; set; } = [];

    /// <summary>
    /// <para>目标权重列表</para>
    /// </summary>
    public record ObjectiveWeight
    {
        /// <summary>
        /// <para>目标 ID，可通过[获取用户 OKR 周期内的目标]接口获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("objective_id")]
        public string ObjectiveId { get; set; } = string.Empty;

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
