// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4TasksRefuseBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>拒绝审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 拒绝审批任务（用户级） 请求体
/// <para>对于单个审批任务进行拒绝操作。拒绝后审批流程结束。</para>
/// <para>接口ID：7642253323628465118</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/refuse</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2frefuse</para>
/// </summary>
public record PostApprovalV4TasksRefuseBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过查询任务列表接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务 ID，可通过查询任务列表接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见，请控制在500个字符以内</para>
    /// <para>必填：否</para>
    /// <para>示例值：拒绝</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
