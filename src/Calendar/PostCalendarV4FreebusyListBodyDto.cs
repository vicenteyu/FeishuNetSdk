using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询主日历忙闲信息 请求体
/// <para>查询用户主日历或会议室的忙闲信息。</para>
/// <para>接口ID：6952888507002912795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2flist</para>
/// </summary>
public record PostCalendarV4FreebusyListBodyDto
{
    /// <summary>
    /// <para>查询时段开始时间，需要url编码</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-10-28T12:00:00+08:00</para>
    /// </summary>
    [JsonProperty("time_min")]
    public string TimeMin { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询时段结束时间，需要url编码</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-12-28T12:00:00+08:00</para>
    /// </summary>
    [JsonProperty("time_max")]
    public string TimeMax { get; set; } = string.Empty;

    /// <summary>
    /// <para>用户user_id，输入时与 room_id 二选一。参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_xxxxxxxxxx</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>会议室room_id，输入时与 user_id 二选一</para>
    /// <para>必填：否</para>
    /// <para>示例值：omm_xxxxxxxxxx</para>
    /// </summary>
    [JsonProperty("room_id")]
    public string? RoomId { get; set; }
}
