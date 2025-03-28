// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-29
//
// Last Modified By : yxr
// Last Modified On : 2025-03-29
// ************************************************************************
// <copyright file="WorkApprovalRevertEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加班审批通过并撤销 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 加班审批通过并撤销 事件体
/// <para>审批定义的表单包含 **加班控件组** 时，该定义下的审批实例在 **通过** 或者 **通过并撤销** 时，会触发该事件。</para>
/// <para>接口ID：7013346140632629276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/overtime</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fovertime</para>
/// </summary>
public record WorkApprovalRevertEventBodyDto() : EventBodyDto("work_approval_revert")
{
    /// <summary>
    /// <para>应用的 App ID。可调用[获取应用信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application/get)接口查询应用详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

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
    /// <para>撤销操作时间，秒级时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }

    /// <summary>
    /// <para>租户 Key，是企业的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>事件类型。固定值 `work_approval_revert`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
