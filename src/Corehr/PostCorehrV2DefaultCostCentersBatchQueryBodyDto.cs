// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2DefaultCostCentersBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询默认成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询默认成本中心 请求体
/// <para>查询默认成本中心</para>
/// <para>接口ID：7486406573931692035</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fbatch_query</para>
/// </summary>
public record PostCorehrV2DefaultCostCentersBatchQueryBodyDto
{
    /// <summary>
    /// <para>员工雇佣 ID 列表</para>
    /// <para>--可以调用[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口，获取指定员工的 employment_id。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[] EmploymentIds { get; set; } = Array.Empty<string>();
}
