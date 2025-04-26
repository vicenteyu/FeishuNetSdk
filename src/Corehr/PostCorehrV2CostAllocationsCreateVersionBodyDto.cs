// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2CostAllocationsCreateVersionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建成本分摊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建成本分摊 请求体
/// <para>创建成本分摊</para>
/// <para>接口ID：7486406573931741187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/create_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fcreate_version</para>
/// </summary>
public record PostCorehrV2CostAllocationsCreateVersionBodyDto
{
    /// <summary>
    /// <para>员工雇佣 ID</para>
    /// <para>-可以调用[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口，获取指定员工的 employment_id。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914821</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>成本分摊</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_allocation")]
    public EmploymentCostAllocation? CostAllocation { get; set; }

    /// <summary>
    /// <para>成本分摊</para>
    /// </summary>
    public record EmploymentCostAllocation
    {
        /// <summary>
        /// <para>分摊生效日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-12-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>分摊失效日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-12-02</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>成本分摊</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("job_data_cost_center_id")]
        public JobDataCostCenter[]? JobDataCostCenterIds { get; set; }

        /// <summary>
        /// <para>成本分摊</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心 ID</para>
            /// <para>-可以调用[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口，获取对应成本中心信息的成本中心ID。</para>
            /// <para>必填：是</para>
            /// <para>示例值：6950635856373745165</para>
            /// </summary>
            [JsonPropertyName("cost_center_id")]
            public string CostCenterId { get; set; } = string.Empty;

            /// <summary>
            /// <para>分摊比例</para>
            /// <para>必填：是</para>
            /// <para>示例值：50.2</para>
            /// </summary>
            [JsonPropertyName("new_rate")]
            public float NewRate { get; set; }
        }

        /// <summary>
        /// <para>变更原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：异动</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
