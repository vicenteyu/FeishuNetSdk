// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrProbationUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>试用期状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 试用期状态变更 事件体
/// <para>当试用期记录状态发生变更时，触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=probation&amp;event=updated)</para>
/// <para>接口ID：7254814386694537218</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/probation-events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fevents%2fupdated</para>
/// </summary>
public record CorehrProbationUpdatedV2EventBodyDto() : EventBodyDto("corehr.probation.updated_v2")
{
    /// <summary>
    /// <para>雇佣 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>试用期状态</para>
    /// <para>**可选值有**：</para>
    /// <para>pending:审批中,rejected:已拒绝,waiting:待发起转正,approved:审批通过,converted:已转正,offboarded:已离职</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>pending：审批中</item>
    /// <item>rejected：已拒绝</item>
    /// <item>waiting：待发起转正</item>
    /// <item>approved：审批通过</item>
    /// <item>converted：已转正</item>
    /// <item>offboarded：已离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("probation_status")]
    public string? ProbationStatus { get; set; }

    /// <summary>
    /// <para>试用期实际结束日期，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("actual_probation_end_date")]
    public string? ActualProbationEndDate { get; set; }
}
