namespace FeishuNetSdk.Calendar;
/// <summary>
/// 创建请假日程 请求体
/// <para>调用该接口为指定用户创建一个请假日程。请假日程分为普通日程和全天日程。创建请假日程后，在请假时间内，用户个人签名页会展示请假信息。</para>
/// <para>接口ID：6952888507003142171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/timeoff_event/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ftimeoff_event%2fcreate</para>
/// </summary>
public record PostCalendarV4TimeoffEventsBodyDto
{
    /// <summary>
    /// <para>用户 ID。ID 类型需要与 user_id_type 的值保持一致。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_XXXXXXXXXX</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>时区信息。</para>
    /// <para>必填：是</para>
    /// <para>示例值：Asia/Shanghai</para>
    /// </summary>
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    /// <summary>
    /// <para>请假开始时间。支持以下任一格式：</para>
    /// <para>- 秒级时间戳：通过时间戳设置的请假日程为普通日程，即按小时请假。取值示例 `1609430400`</para>
    /// <para>- 日期格式：通过日期设置的请假日程为全天日程。取值示例 `2021-01-01`</para>
    /// <para>**注意**：start_time 和 end_time 所选用的时间格式必须保持一致，否则无效。</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-01-01</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>请假结束时间。支持以下任一格式：</para>
    /// <para>- 秒级时间戳：通过时间戳设置的请假日程为普通日程，即按小时请假。取值示例 `1609430400`</para>
    /// <para>- 日期格式：通过日期设置的请假日程为全天日程。取值示例 `2021-01-01`</para>
    /// <para>**注意**：start_time 和 end_time 所选用的时间格式必须保持一致，否则无效。</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-01-01</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义请假日程标题。</para>
    /// <para>**默认值**：空，使用默认标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：请假中(全天) / 1-Day Time Off</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>自定义请假日程描述。</para>
    /// <para>**默认值**：空，使用默认描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：若删除此日程，飞书中相应的“请假”标签将自动消失，而请假系统中的休假申请不会被撤销。</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
