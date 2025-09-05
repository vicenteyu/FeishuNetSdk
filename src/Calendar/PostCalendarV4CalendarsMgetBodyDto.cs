// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-05
//
// Last Modified By : yxr
// Last Modified On : 2025-09-05
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询日历信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 批量查询日历信息 请求体
/// <para>调用该接口批量查询指定日历的标题、描述、公开范围等信息。</para>
/// <para>接口ID：7327132452408410116</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/mget-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fmget</para>
/// </summary>
public record PostCalendarV4CalendarsMgetBodyDto
{
    /// <summary>
    /// <para>日历 ID 列表，多个 ID 传入格式为 `["xxx1", "xxx2"]`。</para>
    /// <para>创建共享日历时会返回日历 ID。你也可以调用以下接口获取某一日历的 ID。</para>
    /// <para>- [查询主日历信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/primary)</para>
    /// <para>- [查询日历列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/list)</para>
    /// <para>- [搜索日历](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/search)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("calendar_ids")]
    public string[] CalendarIds { get; set; } = Array.Empty<string>();
}
