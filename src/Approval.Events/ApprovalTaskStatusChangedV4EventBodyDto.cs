// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-17
//
// Last Modified By : yxr
// Last Modified On : 2026-07-17
// ************************************************************************
// <copyright file="ApprovalTaskStatusChangedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批任务状态变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 审批任务状态变更事件 事件体
/// <para>审批任务状态发生变更时会触发该事件。状态变更包括：</para>
/// <para>- 用户创建审批实例后，推送第一个审批节点的审批任务 `PENDING` 状态。</para>
/// <para>- 如果当前审批节点是会签（AND）节点：</para>
/// <para>- 任一审批任务被同意，推送该任务的 `APPROVED`（已通过）状态，并推送当前节点剩余任务的 `PENDING` 状态。</para>
/// <para>- 任一审批任务被拒绝，推送该任务的 `REJECTED`（已拒绝）状态，并推送当前节点剩余任务的 `DONE` 状态。</para>
/// <para>- 如果当前节点是或签（OR）节点：</para>
/// <para>- 任一审批任务被同意，推送该任务的 `APPROVED`（已通过）状态，并推送当前节点剩余任务的 `DONE`（已完成）状态、下一个节点所有任务的 `PENDING`（进行中）状态。</para>
/// <para>- 任一审批任务被拒绝，推送该任务的 `REJECTED`（已拒绝）状态，并推送当前节点剩余任务的 `DONE`（已完成）状态。</para>
/// <para>- 如果用户对审批任务进行转交，推送该任务的 `TRANSFERRED`（已转交）状态，和被转交人任务的 `PENDING`（进行中）状态。</para>
/// <para>- 发起人撤回审批后，推送剩余所有任务的 `DONE`（已完成）状态。</para>
/// <para>- 审批定义被管理员删除后，推送剩余所有任务的 `DONE`（已完成）状态。</para>
/// <para>- 如果用户对审批任务进行退回，推送该任务的 `ROLLBACK`（已退回）状态，和被退回人任务的 `PENDING`（进行中）状态。</para>
/// <para>- 如果进行中的审批任务超时未处理被关闭，推送该任务的 `OVERTIME_CLOSE`（超时未处理被关闭）状态。</para>
/// <para>- 如果超时已关闭的审批任务被手动恢复，推送该任务的 `OVERTIME_RECOVER`（超时已关闭的任务被手动恢复）状态。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=approval&amp;version=v4&amp;resource=task&amp;event=status_changed)</para>
/// <para>接口ID：7663359183039827209</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fevents%2fstatus_changed</para>
/// </summary>
public record ApprovalTaskStatusChangedV4EventBodyDto() : EventBodyDto("approval.task.status_changed_v4")
{
    /// <summary>
    /// <para>审批定义code</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例code</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批任务id</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>三方审批任务id（仅为三方审批时有值）</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `128` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_external_id")]
    public string? TaskExternalId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assigned_user")]
    public UserIdSuffix? AssignedUser { get; set; }

    /// <summary>
    /// <para>任务状态</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>事件触发时间</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }
}
