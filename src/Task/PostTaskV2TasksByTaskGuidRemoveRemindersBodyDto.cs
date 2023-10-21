using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 移除任务提醒 请求体
/// <para>将一个提醒从任务中移除。</para>
/// <para>如果要移除的提醒本来就不存在，本接口将直接返回成功。</para>
/// <para>接口ID：7255580838154829852</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/remove_reminders</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_reminders</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidRemoveRemindersBodyDto
{
    /// <summary>
    /// <para>要移除的reminder的id列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("reminder_ids")]
    public string[] ReminderIds { get; set; } = Array.Empty<string>();
}
