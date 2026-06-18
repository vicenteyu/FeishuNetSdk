// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4TasksPassBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>同意审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 同意审批任务（用户级） 请求体
/// <para>对于单个审批任务进行同意操作。同意后审批流程会流转到下一个审批人。</para>
/// <para>接口ID：7642253323628383198</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/pass</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fpass</para>
/// </summary>
public record PostApprovalV4TasksPassBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过审批列表相关接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务 ID，可通过审批列表相关接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>表单数据，默认不需要传，仅有该节点需要录入的表单字段才需要传入</para>
    /// <para>必填：否</para>
    /// <para>示例值：[{"id":"user_name", "type": "input", "value":"ou_123avcssa111"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string? Form { get; set; }

    /// <summary>
    /// <para>审批意见</para>
    /// <para>必填：否</para>
    /// <para>示例值：同意</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
