// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-17
//
// Last Modified By : yxr
// Last Modified On : 2026-07-17
// ************************************************************************
// <copyright file="ApprovalInstanceStatusChangedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批实例状态变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 审批实例状态变更事件 事件体
/// <para>审批实例状态发生变更时会触发该事件。状态变更包括：</para>
/// <para>- 用户创建审批后，触发该事件并推送 PENDING（审批中）状态。</para>
/// <para>- 审批实例内，任一审批人拒绝审批任务后，触发该事件并推送 REJECTED（已拒绝）状态。</para>
/// <para>- 审批实例内，所有审批任务均同意后，触发该事件并推送 APPROVED（已通过）状态。</para>
/// <para>- 发起人撤回审批后，推送 CANCELED（已撤回）状态。</para>
/// <para>- 审批定义下存在审批中的审批实例时，若该审批定义被管理员删除，则触发该事件并推送 DELETED（已删除）状态。</para>
/// <para>- 发起人撤销已通过的审批时，触发该事件并推送 REVERTED（已撤销）状态。</para>
/// <para>- 审批实例超时未处理被关闭，触发该事件并推送 OVERTIME_CLOSE（超时被关闭）状态。</para>
/// <para>- 已超时的审批实例被手动恢复，触发该事件并推送 OVERTIME_RECOVER（超时实例被恢复）状态。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=approval&amp;version=v4&amp;resource=instance&amp;event=status_changed)</para>
/// <para>接口ID：7663359183039843593</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fevents%2fstatus_changed</para>
/// </summary>
public record ApprovalInstanceStatusChangedV4EventBodyDto() : EventBodyDto("approval.instance.status_changed_v4")
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
    /// <para>审批实例三方id（仅为三方审批时有值）</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `128` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>事件发生事件，毫秒时间戳</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `64` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_user")]
    public UserIdSuffix? StartUser { get; set; }
}
