// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrOffboardingUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离职信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 离职信息变更 事件体
/// <para>当员工的离职信息变更会发送消息。例如在 [离职管理](https://people.feishu.cn/people/members/dimission/management) &gt; 离职详情页 &gt; 编辑 中修改了离职信息，该事件会推送对应变更的消息。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=offboarding&amp;event=updated)</para>
/// <para>接口ID：7372168594387828740</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/resignation-events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fevents%2fupdated</para>
/// </summary>
public record CorehrOffboardingUpdatedV2EventBodyDto() : EventBodyDto("corehr.offboarding.updated_v2")
{
    /// <summary>
    /// <para>飞书人事的租户ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    /// <summary>
    /// <para>离职记录ID，每条离职记录的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offboarding_info_id")]
    public string? OffboardingInfoId { get; set; }

    /// <summary>
    /// <para>离职申请流程的实例 ID，可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>离职流转流程的实例ID，可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("checklist_process_id")]
    public string? ChecklistProcessId { get; set; }

    /// <summary>
    /// <para>离职员工雇佣ID，可通过[批量查询员工信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>操作人雇佣ID，可通过[批量查询员工信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// <para>变更后的离职状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:离职发起 = 审批中状态,2:审批通过,3:已离职,4:已拒绝,5:已撤销,6:无需审批</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：离职发起 = 审批中状态</item>
    /// <item>2：审批通过</item>
    /// <item>3：已离职</item>
    /// <item>4：已拒绝</item>
    /// <item>5：已撤销</item>
    /// <item>6：无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>变更后的离职手续办理状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:未发起,2:进行中,3:已完成,4:已拒绝,5:已撤销</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：未发起</item>
    /// <item>2：进行中</item>
    /// <item>3：已完成</item>
    /// <item>4：已拒绝</item>
    /// <item>5：已撤销</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("checklist_status")]
    public int? ChecklistStatus { get; set; }

    /// <summary>
    /// <para>更新时间毫秒时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updated_time")]
    public string? UpdatedTime { get; set; }

    /// <summary>
    /// <para>变更离职信息字段的唯一标识列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updated_fields")]
    public string[]? UpdatedFields { get; set; }

    /// <summary>
    /// <para>离职员工的用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }
}
