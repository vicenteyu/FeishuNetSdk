// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="TaskTaskUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任务信息变更（应用维度） 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task.Events;
/// <summary>
/// 任务信息变更（应用维度） 事件体
/// <para>当 APP 订阅此事件后可以接收到由该 APP 创建的任务发生的变更，包括任务标题、描述、截止时间、协作者、关注者、提醒时间、状态（完成或取消完成）。</para>
/// <para>**特别注意**: 订阅该事件只能接收到该 APP 创建的任务发生的变更，如果订阅后未收到事件，可以检查是否是下面几种不会推送的情况:</para>
/// <para>- 任务是user_access_token方式创建或者其他应用创建的。</para>
/// <para>- 任务是通过客户端或者文档创建的。</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=task&amp;version=v1&amp;resource=task&amp;event=updated)</para>
/// <para>接口ID：7006161183808552988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fevents%2fupdated</para>
/// </summary>
public record TaskTaskUpdatedV1EventBodyDto() : EventBodyDto("task.task.updated_v1")
{
    /// <summary>
    /// <para>任务ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>通知类型（1：任务详情发生变化，2：任务协作者发生变化，3：任务关注者发生变化，4：任务提醒时间发生变化，5：任务完成，6：任务取消完成，7：任务删除）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("obj_type")]
    public int? ObjType { get; set; }
}
