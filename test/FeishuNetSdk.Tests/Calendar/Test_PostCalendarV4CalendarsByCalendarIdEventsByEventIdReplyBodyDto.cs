// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回复日程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 回复日程 请求体
/// <para>接口ID：7317471576948834305</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar-event/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event%2freply</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "rsvp_status": "accept"
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdReplyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}