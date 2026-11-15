// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="CorehrSeverancePayStatusUpdateV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>被动离职补偿金信息状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 被动离职补偿金信息状态变更 事件体
/// <para>当被动离职补偿金记录状态发生变化时推送该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=severance_pay&amp;event=status_update)</para>
/// <para>接口ID：7667872540325792730</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/events/status_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fevents%2fstatus_update</para>
/// </summary>
public record CorehrSeverancePayStatusUpdateV2EventBodyDto() : EventBodyDto("corehr.severance_pay.status_update_v2")
{
    /// <summary>
    /// <para>租户id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_id")]
    public string? TenantId { get; set; }

    /// <summary>
    /// <para>补偿金业务单id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("severance_pay_id")]
    public string? SeverancePayId { get; set; }

    /// <summary>
    /// <para>流程id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>员工id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>飞书用户id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public string? TargetUserId { get; set; }

    /// <summary>
    /// <para>变更后的补偿金状态（枚举）</para>
    /// <para>- 1：审批中</para>
    /// <para>- 2：审批通过</para>
    /// <para>- 3：已拒绝</para>
    /// <para>- 4：已撤销</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 取值范围：`0` ～ `4`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }
}
