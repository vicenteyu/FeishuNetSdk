// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-05
//
// Last Modified By : yxr
// Last Modified On : 2025-09-05
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsMgetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询日历信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 批量查询日历信息 响应体
/// <para>接口ID：7327132452408410116</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/mget-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsMgetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "calendars": [
            {
                "calendar_id": "feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn",
                "summary": "测试日历",
                "description": "使用开放接口创建日历",
                "permissions": "private",
                "color": -1,
                "type": "shared",
                "summary_alias": "日历备注名",
                "is_deleted": false,
                "is_third_party": false,
                "role": "owner"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsMgetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}