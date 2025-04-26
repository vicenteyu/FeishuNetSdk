// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2CostAllocationsRemoveVersionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除成本分摊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 删除成本分摊 请求体
/// <para>删除成本分摊</para>
/// <para>接口ID：7486406573931724803</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/remove_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fremove_version</para>
/// </summary>
public record PostCorehrV2CostAllocationsRemoveVersionBodyDto
{
    /// <summary>
    /// <para>员工ID，删除时必填</para>
    /// <para>-可以调用[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口，获取指定员工的 employment_id。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7862995757234914824</para>
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
        /// <para>wk_id，删除时必填</para>
        /// <para>-可以调用[【查询成本分摊】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_allocation/batch_query)接口，获取对应成本分摊信息的成本分摊ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：703912325303191204</para>
        /// </summary>
        [JsonPropertyName("wk_id")]
        public string WkId { get; set; } = string.Empty;
    }
}
