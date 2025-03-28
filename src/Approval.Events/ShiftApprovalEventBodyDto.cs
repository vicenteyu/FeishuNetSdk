// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2025-03-29
// ************************************************************************
// <copyright file="ShiftApprovalEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>换班审批 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 换班审批 事件体
/// <para>审批定义的表单包含 **换班控件组** 时，该定义下的审批实例被通过，会触发该事件。</para>
/// <para>接口ID：7013346140632547356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/shift-change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fshift-change</para>
/// </summary>
public record ShiftApprovalEventBodyDto() : EventBodyDto("shift_approval")
{
    /// <summary>
    /// <para>应用的 App ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>租户 Key，是企业的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>事件类型，固定取值 `shift_approval`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>审批实例 Code。可调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)接口查询审批实例详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批定义 Code。可调用[查看指定审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get)接口查询审批定义详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批提交人的 user_id。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }

    /// <summary>
    /// <para>审批提交人的 open_id。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>审批发起时间，秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public int? StartTime { get; set; }

    /// <summary>
    /// <para>审批结束时间，秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public int? EndTime { get; set; }

    /// <summary>
    /// <para>换班时间。示例格式 `2018-12-01 12:00:00`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("shift_time")]
    public string? ShiftTime { get; set; }

    /// <summary>
    /// <para>还班时间。示例格式 `2018-12-01 12:00:00`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("return_time")]
    public string? ReturnTime { get; set; }

    /// <summary>
    /// <para>换班事由。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("shift_reason")]
    public string? ShiftReason { get; set; }
}
