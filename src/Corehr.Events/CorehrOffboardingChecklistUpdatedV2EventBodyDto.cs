// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrOffboardingChecklistUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离职流转状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 离职流转状态变更 事件体
/// <para>离职流转流程的状态变更消息，当离职流转流程发起和产生审批结果时，会触发该事件。离职流转流程是在离职申请审批通过之后发起的流程，一般用于审批核实离职员工的交接事宜。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=offboarding&amp;event=checklist_updated)</para>
/// <para>接口ID：7372168594387861508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/resignation-events/checklist_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fevents%2fchecklist_updated</para>
/// </summary>
public record CorehrOffboardingChecklistUpdatedV2EventBodyDto() : EventBodyDto("corehr.offboarding.checklist_updated_v2")
{
    /// <summary>
    /// <para>离职员工雇佣ID，可通过[批量查询员工信息</para>
    /// <para>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>离职员工的用户ID</para>
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
    /// <para>离职流转流程的实例 ID，可用于[查询流程相关信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)，例如：作为[获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/list)的process_id查询流程详情。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("checklist_process_id")]
    public string? ChecklistProcessId { get; set; }

    /// <summary>
    /// <para>离职流转状态</para>
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
}
