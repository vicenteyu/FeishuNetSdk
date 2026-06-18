// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="PostApprovalV4TasksForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转交审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 转交审批任务（用户级） 请求体
/// <para>对于单个审批任务进行转交操作。转交后审批流程流转给被转交人。</para>
/// <para>接口ID：7651444911796473026</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fforward</para>
/// </summary>
public record PostApprovalV4TasksForwardBodyDto
{
    /// <summary>
    /// <para>审批实例 Code，可通过查询审批列表接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务 ID，可通过查询审批列表接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>被转交人的用户 ID，与user_id_type类型一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_abacc112aa</para>
    /// </summary>
    [JsonPropertyName("transfer_user_id")]
    public string TransferUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见，不超过500个字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：转交给产品专员处理</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
