namespace FeishuNetSdk.Task;
/// <summary>
/// 新增提醒时间 请求体
/// <para>该接口用于创建任务的提醒时间。提醒时间在截止时间基础上做偏移，但是偏移后的结果不能早于当前时间。</para>
/// <para>接口ID：6985127383322312706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-reminder/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-reminder%2fcreate</para>
/// </summary>
public record PostTaskV1TasksByTaskIdRemindersBodyDto
{
    /// <summary>
    /// <para>相对于截止时间的提醒时间（如提前 30 分钟，截止时间后 30 分钟，则为 -30） 任务没有截止时间则为全天任务(截止时间为0)</para>
    /// <para>必填：是</para>
    /// <para>示例值：30</para>
    /// </summary>
    [JsonPropertyName("relative_fire_minute")]
    public int RelativeFireMinute { get; set; }
}
