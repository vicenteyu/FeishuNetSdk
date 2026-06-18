// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4TasksRollbackBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>退回审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 退回审批任务（用户级） 请求体
/// <para>从当前审批任务，退回到已审批的一个或多个任务节点。退回后，已审批节点重新生成审批任务。</para>
/// <para>接口ID：7651444911796489410</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2frollback</para>
/// </summary>
public record PostApprovalV4TasksRollbackBodyDto
{
    /// <summary>
    /// <para>审批实例code，通过审批任务列表获取得到</para>
    /// <para>必填：是</para>
    /// <para>示例值：289330DE-FBF1-4A47-91F9-9EFCCF11BCAE</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>任务id，通过审批任务列表获取得到</para>
    /// <para>必填：是</para>
    /// <para>示例值：6955096766400168956</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见，控制在500个字符以内</para>
    /// <para>必填：否</para>
    /// <para>示例值：不符合要求，退回重新审批</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>节点id，发起节点id为START</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("node_ids")]
    public string[] NodeIds { get; set; } = [];
}
