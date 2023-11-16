namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日历 请求体
/// <para>该接口用于通过关键字查询公共日历或用户主日历。</para>
/// <para>接口ID：6952888507002863643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键字</para>
    /// <para>必填：是</para>
    /// <para>示例值：querywords</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
}
