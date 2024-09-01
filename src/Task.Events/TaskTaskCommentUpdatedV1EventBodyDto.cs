// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="TaskTaskCommentUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任务评论信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task.Events;
/// <summary>
/// 任务评论信息变更 事件体
/// <para>当 APP 创建的任务评论信息发生变更时触发此事件，包括任务评论的创建、回复、更新、删除。</para>
/// <para>**特别注意**: 订阅该事件只能接收到该 APP 创建的任务发生的评论信息变更，如果订阅后未收到事件，可以检查是否是下面几种不会推送的情况:</para>
/// <para>- 任务是user_access_token方式创建或者其他应用创建的。</para>
/// <para>- 任务是通过客户端或者文档创建的。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=task&amp;version=v1&amp;resource=task.comment&amp;event=updated)</para>
/// <para>接口ID：7006161183808536604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fevents%2fupdated</para>
/// </summary>
public record TaskTaskCommentUpdatedV1EventBodyDto() : EventBodyDto("task.task.comment.updated_v1")
{
    /// <summary>
    /// <para>任务ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>任务评论ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment_id")]
    public string? CommentId { get; set; }

    /// <summary>
    /// <para>任务评论父ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; }

    /// <summary>
    /// <para>通知类型（1：创建评论，2：回复评论，3：更新评论，4：删除评论）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("obj_type")]
    public int? ObjType { get; set; }
}
