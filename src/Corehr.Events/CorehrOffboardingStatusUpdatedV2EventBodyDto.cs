// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrOffboardingStatusUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离职申请状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 离职申请状态变更 事件体
/// <para>在发起离职审批、产生审批结果以及离职生效时触发该事件推送对应消息。审批结果产生的场景包括撤销、通过、拒绝审批。</para>
/// <para>- 与原事件[离职申请状态变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/events/updated)相比，该事件多了直接离职产生的事件，且支持「员工数据」范围控制{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=offboarding&amp;event=status_updated)</para>
/// <para>接口ID：7372168594387845124</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/status_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fevents%2fstatus_updated</para>
/// </summary>
public record CorehrOffboardingStatusUpdatedV2EventBodyDto() : EventBodyDto("corehr.offboarding.status_updated_v2")
{
    /// <summary>
    /// <para>离职员工雇佣ID，可通过[批量查询员工信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>离职员工的用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }

    /// <summary>
    /// <para>离职记录ID，每条离职记录的唯一标识。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offboarding_id")]
    public string? OffboardingId { get; set; }

    /// <summary>
    /// <para>离职申请流程的实例 ID，可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>离职状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:离职发起/审批中,2:审批通过,3:已生效（生效日期后自动生效）,4:已拒绝,5:已撤销,6:无需审批</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：离职发起/审批中</item>
    /// <item>2：审批通过</item>
    /// <item>3：已生效（生效日期后自动生效）</item>
    /// <item>4：已拒绝</item>
    /// <item>5：已撤销</item>
    /// <item>6：无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }
}
