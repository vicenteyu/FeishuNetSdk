// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsCommentDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除评论 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 删除评论 事件体
/// <para>公司圈用户删除评论时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=comment&amp;event=deleted)</para>
/// <para>接口ID：7270433540692754435</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/comment/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fcomment%2fevents%2fdeleted</para>
/// </summary>
public record MomentsCommentDeletedV1EventBodyDto() : EventBodyDto("moments.comment.deleted_v1")
{
    /// <summary>
    /// <para>评论 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>评论所属帖子的ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("post_id")]
    public string? PostId { get; set; }
}
