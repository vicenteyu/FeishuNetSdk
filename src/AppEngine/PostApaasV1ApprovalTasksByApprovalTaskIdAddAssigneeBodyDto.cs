// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApaasV1ApprovalTasksByApprovalTaskIdAddAssigneeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>人工任务加签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 人工任务加签 请求体
/// <para>对于人工任务进行加签操作</para>
/// <para>接口ID：7347562540447121409</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/add_assignee</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2fadd_assignee</para>
/// </summary>
public record PostApaasV1ApprovalTasksByApprovalTaskIdAddAssigneeBodyDto
{
    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1783981209205788</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批人列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("approvers")]
    public string[]? Approvers { get; set; }

    /// <summary>
    /// <para>加签类型：</para>
    /// <para>- 并加签：currentAndAddAssign</para>
    /// <para>- 后加签：afterAndAddAssign</para>
    /// <para>必填：否</para>
    /// <para>示例值：currentAndAddAssign</para>
    /// </summary>
    [JsonPropertyName("add_assignee_type")]
    public string? AddAssigneeType { get; set; }

    /// <summary>
    /// <para>加签原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：加签</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string? Opinion { get; set; }
}
