// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4TasksAddSignBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批任务加签（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 审批任务加签（用户级） 请求体
/// <para>通过调用该接口在当前节点增加审批人</para>
/// <para>接口ID：7651444911796505794</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/add_sign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fadd_sign</para>
/// </summary>
public record PostApprovalV4TasksAddSignBodyDto
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
    /// <para>示例值：6955096766400167956</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见，控制在500个字符内</para>
    /// <para>必填：否</para>
    /// <para>示例值：因制度要求，增加业务审批</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>被加签人id，需保持与user_id_type类型一致，该值通过用户相关接口获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("add_sign_user_ids")]
    public string[] AddSignUserIds { get; set; } = [];

    /// <summary>
    /// <para>1/2/3分别代表前加签/后加签/并加签</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最大值：3</para>
    /// <para>最小值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：前加签</item>
    /// <item>2：后加签</item>
    /// <item>3：并加签</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("add_sign_type")]
    public int AddSignType { get; set; }

    /// <summary>
    /// <para>仅在前加签、后加签时需要填写，1/2 分别代表或签/会签</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>最大值：3</para>
    /// <para>最小值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：或签</item>
    /// <item>2：会签</item>
    /// <item>3：依次审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("approval_method")]
    public int? ApprovalMethod { get; set; }
}
