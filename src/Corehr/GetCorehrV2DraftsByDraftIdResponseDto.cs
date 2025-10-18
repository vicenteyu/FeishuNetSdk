// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="GetCorehrV2DraftsByDraftIdResponseDtouTenantApi.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据组织架构调整 ID 查询发起的流程信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据组织架构调整 ID 查询发起的流程信息 响应体
/// <para>用户通过『飞书人事-我的团队/人员管理-组织架构』 发起一个组织架构调整会根据 审批流配置发起 一个或多个审批。之后用户可以通过组织架构调整 ID 查询对应的流程ID，以及审批流状态。如需查询单个审批的详情数据，可通过[根据流程 ID 查询组织架构调整记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get)获取。</para>
/// <para>接口ID：7428890785897218049</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdraft%2fget</para>
/// </summary>
public record GetCorehrV2DraftsByDraftIdResponseDto
{
    /// <summary>
    /// <para>组织架构调整 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6991776076699549697</para>
    /// </summary>
    [JsonPropertyName("draft_id")]
    public string? DraftId { get; set; }

    /// <summary>
    /// <para>组织架构调整状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：编辑中， ==（流程中的组织架构调整不会是该状态）== 该状态是指用户在『飞书人事-我的团队/人员管理-组织架构-发起调整』 中进行编辑时的状态。</item>
    /// <item>1：审批中，流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
    /// <item>2：已完成， ==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 和 部门变更事件获取。 - 人员异动变更事件:[飞书人事-异动-事件](/ssl:/ttdoc/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_change/job-change-events) - 部门变更事件: [飞书人事-组织管理-事件](/ssl:/ttdoc/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created) - 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】(岗位灰度内)</item>
    /// <item>3：已撤销，用户主动撤销审批， 流程会进入已撤销状态。单次调整中的所有流程均为撤销态时，调整才会流转为撤销态。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("draft_status")]
    public string? DraftStatus { get; set; }

    /// <summary>
    /// <para>组织架构调整流程信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_infos")]
    public ProcessInfo[]? ProcessInfos { get; set; }

    /// <summary>
    /// <para>组织架构调整流程信息列表</para>
    /// </summary>
    public record ProcessInfo
    {
        /// <summary>
        /// <para>组织架构调整流程 ID。详情数据可通过[根据流程 ID 查询组织架构调整记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get)获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>组织架构调整流程状态 ==（不建议使用，推荐使用draft_status）==</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：待发起，是指该审批单据还未成功发起。</item>
        /// <item>1：审批中， 流程成功发起，并等待审批人审批。 可以通过『飞书人事-审批-我发起的』 / 『飞书人事-我的团队/人员管理-组织架构-调整记录』 找到审批单据。</item>
        /// <item>2：审批通过，该单据已通过审批， 调整记录等待写入。 一方面，组织架构调整支持拆单功能， 同一个调整可能发起多个审批， 当前审批单可能依赖其他审批通过才能写入。</item>
        /// <item>3：已完成, ==该状态不代表调整的记录生效完成== 由于记录可能是未来生效， 因此记录的状态需通过 人员异动变更事件 和 部门变更事件获取。 - 人员异动变更事件：[飞书人事-异动-事件](/ssl:/ttdoc/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_change/job-change-events) - 部门变更事件: [飞书人事-组织管理-事件](/ssl:/ttdoc/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created) - 岗位变更事件: 【飞书人事-岗职务管理-岗位-事件】(岗位灰度内)</item>
        /// <item>4：已拒绝： 审批未通过。</item>
        /// <item>5：已撤销，用户主动撤销审批， 流程会进入已撤销状态。</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("approval_group_status")]
        public string? ApprovalGroupStatus { get; set; }
    }
}
