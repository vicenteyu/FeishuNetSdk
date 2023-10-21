using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 创建请假日程 请求体
/// <para>为指定用户创建一个请假日程，可以是一个普通请假日程，也可以是一个全天日程。</para>
/// <para>创建请假日程后，会在相应时间内，在用户个人签名页展示请假信息。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=calendar&version=v4&resource=timeoff_event&method=create)</para>
/// <para>接口ID：6952888507003142171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/timeoff_event/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ftimeoff_event%2fcreate</para>
/// </summary>
public record PostCalendarV4TimeoffEventsBodyDto
{
    /// <summary>
    /// <para>用户id，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>**示例值**："ou_XXXXXXXXXX"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>时区</para>
    /// <para>**示例值**："Asia/Shanghai"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("timezone")]
    public string Timezone { get; set; } = string.Empty;

    /// <summary>
    /// <para>休假开始时间：</para>
    /// <para>有时间戳(1609430400)和日期(2021-01-01)两种格式，其它格式无效；</para>
    /// <para>时间戳格式是按小时休假日程，日期格式是全天休假日程；</para>
    /// <para>start_time与end_time格式需保持一致，否则无效。</para>
    /// <para>**示例值**："2021-01-01"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>休假结束时间：</para>
    /// <para>有时间戳(1609430400)和日期(2021-01-01)两种格式，其它格式无效；</para>
    /// <para>时间戳格式是按小时休假日程，日期格式是全天休假日程；</para>
    /// <para>start_time与end_time格式需保持一致，否则无效。</para>
    /// <para>**示例值**："2021-01-01"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义请假日程标题，没有设置则为默认日程标题</para>
    /// <para>**示例值**："请假中(全天) / 1-Day Time Off"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>自定义请假日程描述，没有设置则为默认日程描述</para>
    /// <para>**示例值**："若删除此日程，飞书中相应的“请假”标签将自动消失，而请假系统中的休假申请不会被撤销。"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }
}
