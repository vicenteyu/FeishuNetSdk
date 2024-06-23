// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesByInstanceIdCommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 创建评论 响应体
/// <para>在某审批实例下创建、修改评论或评论回复（不包含审批同意、拒绝、转交等附加的理由或意见）。</para>
/// <para>接口ID：7117964632137154563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fcreate</para>
/// </summary>
public record PostApprovalV4InstancesByInstanceIdCommentsResponseDto
{
    /// <summary>
    /// <para>保存成功的comment_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }
}
