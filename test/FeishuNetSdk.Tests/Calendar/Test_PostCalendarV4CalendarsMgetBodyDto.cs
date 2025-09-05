// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-05
//
// Last Modified By : yxr
// Last Modified On : 2025-09-05
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询日历信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 批量查询日历信息 请求体
/// <para>接口ID：7327132452408410116</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/mget-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsMgetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "calendar_ids": [
        "feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsMgetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}