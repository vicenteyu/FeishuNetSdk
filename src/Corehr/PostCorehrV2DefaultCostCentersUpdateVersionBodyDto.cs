// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2DefaultCostCentersUpdateVersionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新默认成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新默认成本中心 请求体
/// <para>更新默认成本中心</para>
/// <para>接口ID：7486406573931642883</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/update_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fupdate_version</para>
/// </summary>
public record PostCorehrV2DefaultCostCentersUpdateVersionBodyDto
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
    /// <para>默认成本中心信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("default_cost_center")]
    public EmploymentDefaultCostCenter? DefaultCostCenter { get; set; }

    /// <summary>
    /// <para>默认成本中心信息</para>
    /// </summary>
    public record EmploymentDefaultCostCenter
    {
        /// <summary>
        /// <para>wk_id</para>
        /// <para>-可以调用[【查询默认成本中心】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/default_cost_center/batch_query)接口，获取对应默认成本中心信息的默认成本中心ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：703912325303191204</para>
        /// </summary>
        [JsonPropertyName("wk_id")]
        public string WkId { get; set; } = string.Empty;

        /// <summary>
        /// <para>wk_tid</para>
        /// <para>-可以调用[【查询默认成本中心】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/default_cost_center/batch_query)接口，获取对应默认成本中心信息的默认成本中心版本ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：703912321231239801</para>
        /// </summary>
        [JsonPropertyName("wk_tid")]
        public string WkTid { get; set; } = string.Empty;

        /// <summary>
        /// <para>生效日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-12-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string? EffectiveTime { get; set; }

        /// <summary>
        /// <para>成本中心 ID</para>
        /// <para>-可以调用[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口，获取对应成本中心信息的成本中心ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7039123253031711012</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>是否继承自岗位/部门的默认成本中心</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_inherit")]
        public bool? IsInherit { get; set; }

        /// <summary>
        /// <para>变更原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：异动</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
