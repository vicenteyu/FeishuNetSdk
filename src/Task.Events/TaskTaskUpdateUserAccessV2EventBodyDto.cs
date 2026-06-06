// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="TaskTaskUpdateUserAccessV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>任务更新事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task.Events;
/// <summary>
/// 任务更新事件 事件体
/// <para>任务事件，事件类型包括： 任务创建、任务删除、任务标题变更、任务负责人变更、任务完整状态变更、任务描述变更、任务关注人变更、任务提醒事件变更、任务开始和截止时间变更{使用示例}(url=/api/tools/api_explore/api_explore_config?project=task&amp;version=v2&amp;resource=task&amp;event=update_user_access)</para>
/// <para>接口ID：7645220598528167100</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/events/update_user_access</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fevents%2fupdate_user_access</para>
/// </summary>
public record TaskTaskUpdateUserAccessV2EventBodyDto() : EventBodyDto("task.task.update_user_access_v2")
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>- `task_assignees_update`：任务负责人变更</para>
    /// <para>- `task_completed_update`：任务完整状态变更</para>
    /// <para>- `task_create`：任务创建</para>
    /// <para>- `task_deleted`：任务删除</para>
    /// <para>- `task_desc_update`：任务描述变更</para>
    /// <para>- `task_followers_update`：任务关注人变更</para>
    /// <para>- `task_reminders_update`：任务提醒事件变更</para>
    /// <para>- `task_start_due_update`：任务开始和截止时间变更</para>
    /// <para>- `task_summary_update`：任务标题变更</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `100`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_types")]
    public string[]? EventTypes { get; set; }

    /// <summary>
    /// <para>任务GUID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_guid")]
    public string? TaskGuid { get; set; }
}
