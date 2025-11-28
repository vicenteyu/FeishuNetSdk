// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidAddRemindersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加任务提醒 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 添加任务提醒 请求体
/// <para>为一个任务添加提醒。提醒是基于任务的截止时间计算得到的一个时刻。为了设置提醒，任务必须首先拥有截止时间(due)。可以在[创建任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/create)时设置截止时间，或者通过[更新任务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/patch)设置一个截止时间。</para>
/// <para>目前一个任务只能设置1个提醒。但接口的形式可以在未来扩充为一个任务支持多个提醒。</para>
/// <para>如果当前任务已经有提醒了，要更新提醒的设置，需要先调用[移除任务提醒](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders)接口移除原有提醒。再调用本接口添加提醒。</para>
/// <para>接口ID：7255580838154813468</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_reminders</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_reminders</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidAddRemindersBodyDto
{
    /// <summary>
    /// <para>要添加的reminder的列表，目前1个任务只支持一个提醒。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：1</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("reminders")]
    public Reminder[] Reminders { get; set; } = [];

    /// <summary>
    /// <para>要添加的reminder的列表，目前1个任务只支持一个提醒。</para>
    /// </summary>
    public record Reminder
    {
        /// <summary>
        /// <para>相对于截止时间的提醒时间分钟数。例如30表示截止时间前30分钟提醒；0表示截止时提醒。</para>
        /// <para>不支持负数。</para>
        /// <para>必填：是</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("relative_fire_minute")]
        public int RelativeFireMinute { get; set; }
    }
}
