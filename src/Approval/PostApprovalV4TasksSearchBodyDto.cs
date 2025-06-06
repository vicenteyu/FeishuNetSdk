// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4TasksSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询任务列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询任务列表 请求体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批任务列表。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口会过滤被撤销的审批实例，实例内的任务也会被过滤掉，因此会有任务存在却不返回数据的情况。</para>
/// <para>该情况的具体表现：返回结果中每页的数据条目数可能小于 page_size 值。例如，page_size 取值为 10，实际查询结果中当前页只显示 6 条数据，则表示有 4 条数据是被撤销实例内的任务。</para>
/// <para>- 该接口查询结果可能存在延迟，无法保证实时性。如需实时查询，建议使用[查询用户的任务列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/query)。</para>
/// <para>- 查询时：</para>
/// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
/// <para>- approval_code 和 group_external_id 查询结果取并集；instance_code 和 instance_external_id 查询结果取并集；其他查询条件之间均取交集。</para>
/// <para>接口ID：7117964632137138179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fsearch</para>
/// </summary>
public record PostApprovalV4TasksSearchBodyDto
{
    /// <summary>
    /// <para>任务审批人 ID，ID 类型与查询参数 user_id_type 保持一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：lwiu098wj</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- approval_code 和 group_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED942</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 Code。获取方式：</para>
    /// <para>- 调用[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)接口后，从响应参数 instance_code 获取。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)接口，获取所需的审批实例 Code。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- instance_code 和 instance_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例的第三方 ID。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- instance_code 和 instance_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED976</para>
    /// </summary>
    [JsonPropertyName("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组的第三方 ID。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- approval_code 和 group_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234567</para>
    /// </summary>
    [JsonPropertyName("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批任务标题。</para>
    /// <para>**说明**：仅第三方审批存在审批任务标题。</para>
    /// <para>必填：否</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonPropertyName("task_title")]
    public string? TaskTitle { get; set; }

    /// <summary>
    /// <para>审批任务状态。</para>
    /// <para>**注意**：若不设置则查询全部状态，若不在集合中，则报错。</para>
    /// <para>必填：否</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>REJECTED：已拒绝</item>
    /// <item>APPROVED：已通过</item>
    /// <item>TRANSFERRED：已转交</item>
    /// <item>DONE：已完成</item>
    /// <item>RM_REPEAT：去重</item>
    /// <item>PROCESSED：已处理</item>
    /// <item>ALL：所有状态</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("task_status")]
    public string? TaskStatus { get; set; }

    /// <summary>
    /// <para>任务查询开始时间，Unix 毫秒时间戳。与 task_start_time_to 参数构成时间段查询条件，仅会返回在该时间段内的审批任务。</para>
    /// <para>**注意**：查询时间跨度不得大于 30 天，开始和结束时间必须同时设置或者同时不设置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("task_start_time_from")]
    public string? TaskStartTimeFrom { get; set; }

    /// <summary>
    /// <para>任务查询结束时间，Unix 毫秒时间戳。与 task_start_time_from 参数构成时间段查询条件，仅会返回在该时间段内的审批任务。</para>
    /// <para>**注意**：查询时间跨度不得大于 30 天，开始和结束时间必须同时设置或者同时不设置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("task_start_time_to")]
    public string? TaskStartTimeTo { get; set; }

    /// <summary>
    /// <para>语言。</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh-CN</para>
    /// <para>可选值：<list type="bullet">
    /// <item>zh-CN：中文</item>
    /// <item>en-US：英文</item>
    /// <item>ja-JP：日文</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>查询多种状态的任务，当填写此参数时，task_status 参数将失效。</para>
    /// <para>**可选值有**：</para>
    /// <para>- `PENDING`：审批中</para>
    /// <para>- `REJECTED`：拒绝</para>
    /// <para>- `APPROVED`：通过</para>
    /// <para>- `TRANSFERRED`：转交</para>
    /// <para>- `DONE`：已完成</para>
    /// <para>- `RM_REPEAT`：去重</para>
    /// <para>- `PROCESSED`：已处理</para>
    /// <para>必填：否</para>
    /// <para>示例值：PENDING</para>
    /// </summary>
    [JsonPropertyName("task_status_list")]
    public string[]? TaskStatusList { get; set; }

    /// <summary>
    /// <para>按任务时间排序</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：按审批任务更新时间（update_time）倒排。</item>
    /// <item>1：按审批任务更新时间（update_time）正排。</item>
    /// <item>2：按审批任务开始时间（start_time）倒排。</item>
    /// <item>3：按审批任务开始时间（start_time）正排。</item>
    /// </list></para>
    /// <para>默认值：2</para>
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }
}
