// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteApprovalV4InstancesByInstanceIdCommentsByCommentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 删除评论 响应体
/// <para>删除某审批实例下的一条评论或评论回复（不包含审批同意、拒绝、转交等附加的理由或意见），删除后在审批中心的审批实例内不再显示评论内容，而是显示 **评论已删除**。</para>
/// <para>接口ID：7117964632137121795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fdelete</para>
/// </summary>
public record DeleteApprovalV4InstancesByInstanceIdCommentsByCommentIdResponseDto
{
    /// <summary>
    /// <para>被删除的评论 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7081516627711606803</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }
}
