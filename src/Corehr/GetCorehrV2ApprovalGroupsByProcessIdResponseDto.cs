// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetCorehrV2ApprovalGroupsByProcessIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据流程 ID 查询组织架构调整记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据流程 ID 查询组织架构调整记录 响应体
/// <para>用户通过『飞书人事-我的团队-组织架构』 发起一个组织架构调整会根据 审批流配置发起 一个或多个审批。 之后用户可通过流程 process 的单据 ID， 查询到该审批进行的状态， 以及该流程中涉及到的 组织架构信息（包括部门变更、人员变更记录 ID、岗位变更记录 ID）。</para>
/// <para>如需查询具体变更详情：</para>
/// <para>- 部门变更：[批量查询部门变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids)</para>
/// <para>- 员工变更：[批量查询员工变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_job_change_list_by_ids)</para>
/// <para>接口ID：7317581509003755524</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fget</para>
/// </summary>
public record GetCorehrV2ApprovalGroupsByProcessIdResponseDto
{
    /// <summary>
    /// <para>组织架构调整流程信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_group")]
    public GetCorehrV2ApprovalGroupsByProcessIdResponseDtoApprovalGroup? ApprovalGroup { get; set; }

    /// <summary>
    /// <para>组织架构调整流程信息</para>
    /// </summary>
    public record GetCorehrV2ApprovalGroupsByProcessIdResponseDtoApprovalGroup
    {
        /// <summary>
        /// <para>组织架构调整审批组 ID， 该 ID 和 process_id 一一对应</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("approval_group_id")]
        public string? ApprovalGroupId { get; set; }

        /// <summary>
        /// <para>组织架构调整对应的流程 ID， 与入参 process_id 对应。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>组织架构调整流程状态，枚举类型， 描述该审批单据的状态。</para>
        /// <para>【不推荐使用，无法区分审批通过、执行失败和等待执行状态，推荐使用approval_group_status_v2】</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：待发起，是指该审批单据还未成功发起。</item>
        /// <item>1：审批中， 流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
        /// <item>2：审批通过，该单据已通过审批， 调整记录等待写入。 一方面，组织架构调整支持拆单功能， 同一个调整可能发起多个审批， 当前审批单可能依赖其他审批通过才能写入。</item>
        /// <item>3：已完成，审批单中所有调整记录均写入完成。 ==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件、部门变更事件 和 岗位变更事件 获取。 - 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated) - 部门变更事件: [飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created) - 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】(岗位灰度内)</item>
        /// <item>4：已拒绝，审批未通过。</item>
        /// <item>5：已撤销，用户主动撤销审批，流程会进入已撤销状态。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("approval_group_status")]
        public string? ApprovalGroupStatus { get; set; }

        /// <summary>
        /// <para>组织架构调整流程状态，枚举类型， 描述该审批单据的状态。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：待发起，是指该审批单据还未成功发起。</item>
        /// <item>1：审批中， 流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
        /// <item>2：审批通过，该单据已通过审批， 调整记录等待写入。</item>
        /// <item>3：已完成，审批单中所有调整记录均写入完成。 ==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 、部门变更事件 和 岗位变更事件 获取。 - 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated) - 部门变更事件: [飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created) - 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】(岗位灰度内)</item>
        /// <item>4：已拒绝，审批未通过。</item>
        /// <item>5：已撤销，用户主动撤销审批， 流程会进入已撤销状态。</item>
        /// <item>6：执行失败 或 等待执行。 - 该类型事件触发时机如下： - 商业化租户，未配置拆分审批流（整单）： - 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。 - 商业化租户，且配置拆分审批流（合单）： - 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。 - 审批单执行生效依赖另一个同时发起的还处于审批中状态审批单的执行结果，此时审批单状态为【等待执行】，会触发该类型事件发送。当被依赖审批单审批通过后，该审批单会根据执行结果再次发送【已完成】或【执行失败】事件。 - 字节租户： - 审批单中存在执行失败的调整项，此时审批单状态为【执行失败】，会触发该类型事件发送。 - 包含人员异动的审批单，审批通过时间早于审批单生效时间，此时审批单状态为【等待执行】，会触发该类型事件发送。到达审批单生效时间后，会根据执行结果再次发送【已完成】或【执行失败】事件。 - 用户收到该事件后，可通过以下接口查询审批单中包含调整记录的状态和变更详情： - 人员调整记录：[批量查询人员调整内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_job_change_list_by_ids) ==调整记录状态待支持== - 部门调整记录：[批量查询部门调整内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids) - 岗位调整记录：【飞书人事-组织架构调整-批量查询岗位调整内容】(岗位灰度内)==调整记录状态待支持==</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("approval_group_status_v2")]
        public int? ApprovalGroupStatusV2 { get; set; }

        /// <summary>
        /// <para>调整主题， 用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：因组织发展需要， 变更XXX 部门组织架构</para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// <para>调整原因，用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更详细原因， 便于审批人批阅。</para>
        /// <para>必填：否</para>
        /// <para>示例值：例如：因业务扩展需要， 现需增设 XXX 和 XXX 两个区域部门，便于上午拓展。</para>
        /// </summary>
        [JsonPropertyName("adjust_reason")]
        public string? AdjustReason { get; set; }

        /// <summary>
        /// <para>生效日期</para>
        /// <para>- 日期格式：YYYY-MM-DD</para>
        /// <para>- 最小值： 1900-01-01</para>
        /// <para>- 最大值： 9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-03-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>发起人，在『飞书人事-我的团队/人员管理 -组织架构-发起调整』填写的调整变更发起人。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974641477444060708</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// <para>组织架构调整 ID，用户在『飞书人事-我的团队/人员管理 -组织架构-发起调整』 时生成的唯一 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("draft_id")]
        public string? DraftId { get; set; }

        /// <summary>
        /// <para>流程对应组织架构调整的状态： process_status 是发起审批后的状态，而 draft_status 则是整个组织架构调整的状态。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Edit</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：编辑中， ==（流程中的组织架构调整不会是该状态）== 该状态是指用户在『飞书人事-我的团队/人员管理-组织架构-发起调整』 中进行编辑时的状态。</item>
        /// <item>1：审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
        /// <item>2：已完成， ==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 和 部门变更事件获取。 - 人员异动变更事件：[飞书人事-异动-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/events/status_updated) - 部门变更事件: [飞书人事-组织管理-事件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created) - 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】（岗位灰度内）</item>
        /// <item>3：已撤销，用户主动撤销审批， 流程会进入已撤销状态。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("draft_status")]
        public string? DraftStatus { get; set; }

        /// <summary>
        /// <para>关联的部门调整记录 ID 列表。</para>
        /// <para>- 部门变更详情可通过：[批量查询部门变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids)获取</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("department_changes")]
        public string[]? DepartmentChanges { get; set; }

        /// <summary>
        /// <para>关联的人员调整记录 ID 列表, 组织架构调整仅允许调整系统已存在的人员， 当发起审批后会生成一个 job_change 的记录用于记录变更过程。</para>
        /// <para>- 员工变更：[批量查询员工变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_job_change_list_by_ids)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("job_changes")]
        public string[]? JobChanges { get; set; }

        /// <summary>
        /// <para>关联的岗位调整记录 ID 列表。</para>
        /// <para>- 功能灰度中，开通岗位功能后可通过接口【批量查询岗位变更接口】获取岗位变更详情</para>
        /// <para>必填：否</para>
        /// <para>最大长度：5000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("position_changes")]
        public string[]? PositionChanges { get; set; }
    }
}
