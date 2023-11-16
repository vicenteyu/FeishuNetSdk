namespace FeishuNetSdk.Approval;
/// <summary>
/// 获取三方审批任务状态 请求体
/// <para>该接口用于获取三方审批的状态。用户传入查询条件，接口返回满足条件的审批实例的状态。该接口支持多种参数的组合，包括如下组合：</para>
/// <para>1.通过 instance_ids 获取指定实例的任务状态</para>
/// <para>2.通过 user_ids 获取指定用户的任务状态</para>
/// <para>3.通过 status 获取指定状态的所有任务</para>
/// <para>4.通过page_token获取下一批数据</para>
/// <para>接口ID：7117964632137170947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_task%2flist</para>
/// </summary>
public record GetApprovalV4ExternalTasksBodyDto
{
    /// <summary>
    /// <para>审批定义 Code，用于指定只获取这些定义下的数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：B7B65FFE-C2GC-452F-9F0F-9AA8352363D6</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("approval_codes")]
    public string[]? ApprovalCodes { get; set; }

    /// <summary>
    /// <para>审批实例 ID, 用于指定只获取这些实例下的数据，最多支持 20 个</para>
    /// <para>必填：否</para>
    /// <para>示例值：oa_159160304</para>
    /// </summary>
    [JsonPropertyName("instance_ids")]
    public string[]? InstanceIds { get; set; }

    /// <summary>
    /// <para>审批人 user_id，用于指定只获取这些用户的数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：112321</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>审批任务状态，用于指定获取该状态下的数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>APPROVED：审批流程结束，结果为同意</item>
    /// <item>REJECTED：审批流程结束，结果为拒绝</item>
    /// <item>TRANSFERRED：任务转交</item>
    /// <item>DONE：任务通过但审批人未操作；审批人看不到这个任务,若想要看到,可以通过抄送该人.</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
