// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesByInstanceIdCommentsRemoveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>清空评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 清空评论 响应体
/// <para>清空某审批实例下的全部评论与评论回复，包括显示为已删除的评论。</para>
/// <para>接口ID：7117964632137252867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fremove</para>
/// </summary>
public record PostApprovalV4InstancesByInstanceIdCommentsRemoveResponseDto
{
    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：否</para>
    /// <para>示例值：6A123516-FB88-470D-A428-9AF58B71B3C0</para>
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; set; }

    /// <summary>
    /// <para>自定义审批实例 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6A123516-FB88-470D-A428-9AF58B71B3C0</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }
}
