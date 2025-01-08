// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="CorehrApprovalGroupsUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>组织架构调整状态变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 组织架构调整状态变更事件 事件体
/// <para>- 当用户在『飞书人事-我的团队/人员管理-组织架构』，查看调整链接可以获取到 该用户发起的所有组织架构调整， 进入可找到审批流程。</para>
/// <para>- 当该审批单状态发生变更后， 用户会收到流程状态变更事件。</para>
/// <para>- 延迟说明：数据库主从延迟2s以内，即：用户接收到流程状态变更消息后2s内调用查询状态接口可能查不到变更信息。</para>
/// <para>接口ID：7317581509003804676</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fevents%2fupdated</para>
/// </summary>
public record CorehrApprovalGroupsUpdatedV2EventBodyDto() : EventBodyDto("corehr.approval_groups.updated_v2")
{
    /// <summary>
    /// <para>组织架构调整审批组 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_group_id")]
    public string? ApprovalGroupId { get; set; }

    /// <summary>
    /// <para>组织架构调整流程 ID， 用户通过『飞书人事-我的团队-组织架构』或『飞书 人事-人员管理-组织架构』 发起一个组织架构调整，并提交审批后，系统会根据管理员在审批流程中配置的规则，生成 一个或多个审批单据。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>组织架构调整流程状态，枚举类型， 描述该审批单据的状态。</para>
    /// <para>【不推荐使用，无法区分审批通过、执行失败和等待执行状态，推荐使用approval_group_status_v2】</para>
    /// <para>**可选值有**：</para>
    /// <para>1:审批中， 流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。 ,2:审批通过，该单据已通过审批， 调整记录等待写入。 一方面，组织架构调整支持拆单功能， 同一个调整可能发起多个审批， 当前审批单可能依赖其他审批通过才能写入。,3:已完成，审批单中所有调整记录均写入完成。</para>
    /// <para>==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 、部门变更事件 和 岗位变更事件 获取。</para>
    /// <para>- 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated)</para>
    /// <para>- 部门变更事件：[飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)</para>
    /// <para>- 岗位变更事件：【飞书人事-岗职务管理-岗位-事件】(岗位灰度内),4:已拒绝，审批未通过。,5:已撤销，用户主动撤销审批， 流程会进入已撤销状态。</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：审批中， 流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
    /// <item>2：审批通过，该单据已通过审批， 调整记录等待写入。 一方面，组织架构调整支持拆单功能， 同一个调整可能发起多个审批， 当前审批单可能依赖其他审批通过才能写入。</item>
    /// <item>3：已完成，审批单中所有调整记录均写入完成。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("approval_group_status")]
    public int? ApprovalGroupStatus { get; set; }

    /// <summary>
    /// <para>调整主题， 用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更主题</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>
    /// <para>调整原因，用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更详细原因， 便于审批人批阅。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("adjust_reason")]
    public string? AdjustReason { get; set; }

    /// <summary>
    /// <para>生效日期</para>
    /// <para>- 日期格式：YYYY-MM-DD</para>
    /// <para>- 最小值： 1900-01-01</para>
    /// <para>- 最大值： 9999-12-31</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }

    /// <summary>
    /// <para>发起人，在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更发起人。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// <para>组织架构调整 ID，用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』 时生成的唯一 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("draft_id")]
    public string? DraftId { get; set; }

    /// <summary>
    /// <para>整个组织架构调整状态，枚举类型，一个组织架构调整可能涉及多个审批流程。 该状态描述整个调整的审核状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。,2:已完成</para>
    /// <para>==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 、部门变更事件 和 岗位变更事件 获取。</para>
    /// <para>- 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated)</para>
    /// <para>- 部门变更事件： [飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)</para>
    /// <para>- 岗位变更事件：【飞书人事-岗职务管理-岗位-事件】(岗位灰度内),3:已撤销，用户主动撤销审批， 流程会进入已撤销状态。</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
    /// <item>2：已完成，</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("draft_status")]
    public int? DraftStatus { get; set; }

    /// <summary>
    /// <para>组织架构调整流程状态V2，枚举类型，描述该审批单据的状态。==【灰度中】==</para>
    /// <para>**可选值有**：</para>
    /// <para>1:审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。 ,2:审批通过，该单据已通过审批，调整记录等待写入。 ,3:已完成，审批单中所有调整记录均写入完成。</para>
    /// <para>==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 、部门变更事件 和 岗位变更事件 获取。</para>
    /// <para>- 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated)</para>
    /// <para>- 部门变更事件: [飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)</para>
    /// <para>- 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】(岗位灰度内),4:已拒绝，审批未通过。,5:已撤销，用户主动撤销审批，流程会进入已撤销状态。,6:执行失败 或 等待执行。</para>
    /// <para>- 该类型事件触发时机如下：</para>
    /// <para>- 商业化租户，未配置拆分审批流（整单）：</para>
    /// <para>- 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。</para>
    /// <para>- 商业化租户，且配置拆分审批流（合单）：</para>
    /// <para>- 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。</para>
    /// <para>- 审批单执行生效依赖另一个同时发起的还处于审批中状态审批单的执行结果，此时审批单状态为【等待执行】，会触发该类型事件发送。当被依赖审批单审批通过后，该审批单会根据执行结果再次发送【已完成】或【执行失败】事件。</para>
    /// <para>- 字节租户：</para>
    /// <para>- 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。</para>
    /// <para>- 包含人员异动的审批单，审批通过时间早于审批单生效时间，此时审批单状态为【等待执行】，会触发该类型事件发送。到达审批单生效时间后，会根据执行结果再次发送【已完成】或【执行失败】事件。</para>
    /// <para>- 用户收到该事件后，可通过以下接口查询审批单中包含调整记录的状态和变更详情：</para>
    /// <para>- 人员调整记录：[批量查询人员调整内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_job_change_list_by_ids) ==调整记录状态待支持==</para>
    /// <para>- 部门调整记录：[批量查询部门调整内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids)</para>
    /// <para>- 岗位调整记录：【飞书人事-组织架构调整-批量查询岗位调整内容】(岗位灰度内)==调整记录状态待支持==</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
    /// <item>2：审批通过，该单据已通过审批，调整记录等待写入。</item>
    /// <item>3：已完成，审批单中所有调整记录均写入完成。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("approval_group_status_v2")]
    public int? ApprovalGroupStatusV2 { get; set; }
}
