// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回复日程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 回复日程 请求体
/// <para>调用该接口以当前身份（应用或用户）回复日程。</para>
/// <para>接口ID：7317471576948834305</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2freply</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto
{
    /// <summary>
    /// <para>日程参与人 RSVP 状态，即日程回复状态。</para>
    /// <para>必填：是</para>
    /// <para>示例值：accept</para>
    /// <para>可选值：<list type="bullet">
    /// <item>accept：接受</item>
    /// <item>decline：拒绝</item>
    /// <item>tentative：待定</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("rsvp_status")]
    public string RsvpStatus { get; set; } = string.Empty;
}
