// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobChangeUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>异动信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 异动信息变更 事件体
/// <para>员工发起异动后，异动信息变更会触发该事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=job_change&amp;event=updated)</para>
/// <para>接口ID：7372191514485243908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/job-change-events/updated-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fevents%2fupdated</para>
/// </summary>
public record CorehrJobChangeUpdatedV2EventBodyDto() : EventBodyDto("corehr.job_change.updated_v2")
{
    /// <summary>
    /// <para>异动员工雇员ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>Saas租户ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    /// <summary>
    /// <para>流程ID，可通过【流程-获取单个流程详情】接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>发起人雇员ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("initiator")]
    public string? Initiator { get; set; }

    /// <summary>
    /// <para>操作人雇员ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// <para>更新时间毫秒时间戳</para>
    /// <para>- 示例：1714985958000</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updated_time")]
    public string? UpdatedTime { get; set; }

    /// <summary>
    /// <para>异动记录ID，可通过接口</para>
    /// <para>[搜索异动信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/search)获取详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_change_id")]
    public string? JobChangeId { get; set; }

    /// <summary>
    /// <para>变更后异动状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:异动发起 = 审批中状态,2:已撤销,3:已拒绝,4:审批通过,5:已生效（到了生效日期后就生效）,6:无需审批</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：异动发起 = 审批中状态</item>
    /// <item>2：已撤销</item>
    /// <item>3：已拒绝</item>
    /// <item>4：审批通过</item>
    /// <item>5：已生效（到了生效日期后就生效）</item>
    /// <item>6：无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>操作原因</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_reason")]
    public string? OperateReason { get; set; }

    /// <summary>
    /// <para>变更类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:异动页面编辑,2:任职记录编辑,3:花名册导入编辑,4:试用期页面编辑,5:处理异常编辑,6:异动流程编辑,7:合同编辑</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：异动页面编辑</item>
    /// <item>2：任职记录编辑</item>
    /// <item>3：花名册导入编辑</item>
    /// <item>4：试用期页面编辑</item>
    /// <item>5：处理异常编辑</item>
    /// <item>6：异动流程编辑</item>
    /// <item>7：合同编辑</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("transfer_type")]
    public int? TransferType { get; set; }

    /// <summary>
    /// <para>变更字段</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updated_fields")]
    public string[]? UpdatedFields { get; set; }

    /// <summary>
    /// <para>异动类型，可通过接口</para>
    /// <para>[获取异动类型列表</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_type/query)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transform_type")]
    public string? TransformType { get; set; }

    /// <summary>
    /// <para>异动原因，可通过接口</para>
    /// <para>[获取异动原因列表</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_reason/query)获取详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transform_reason")]
    public string? TransformReason { get; set; }
}
