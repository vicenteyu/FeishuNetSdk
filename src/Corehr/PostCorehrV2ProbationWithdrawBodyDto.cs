// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2ProbationWithdrawBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销转正 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销转正 请求体
/// <para>可通过本接口撤销对员工之前发起的转正</para>
/// <para>接口ID：7254814386694651906</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation/withdraw</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fwithdraw</para>
/// </summary>
public record PostCorehrV2ProbationWithdrawBodyDto
{
    /// <summary>
    /// <para>试用期人员的雇佣 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;
}
