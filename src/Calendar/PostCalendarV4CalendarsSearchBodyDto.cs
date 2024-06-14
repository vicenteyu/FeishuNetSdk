namespace FeishuNetSdk.Calendar;
/// <summary>
/// 搜索日历 请求体
/// <para>调用该接口通过关键字搜索日历，搜索结果为标题或描述包含关键字的公共日历或用户主日历。</para>
/// <para>接口ID：6952888507002863643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fsearch</para>
/// </summary>
public record PostCalendarV4CalendarsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键字。接口将会搜索标题或描述中包含该关键字的公共日历或用户主日历。</para>
    /// <para>必填：是</para>
    /// <para>示例值：query words</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
}
