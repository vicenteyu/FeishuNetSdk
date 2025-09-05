// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-03
//
// Last Modified By : yxr
// Last Modified On : 2025-09-03
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsPrimarysResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取主日历信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 批量获取主日历信息 响应体
/// <para>接口ID：7327132452408393732</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/primarys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fprimarys</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsPrimarysResponseDto : TestBase
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
                "calendar": {
                    "calendar_id": "feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn",
                    "summary": "测试日历",
                    "description": "使用开放接口创建日历",
                    "permissions": "private",
                    "color": -1,
                    "type": "primary",
                    "summary_alias": "日历备注名",
                    "is_deleted": false,
                    "is_third_party": false,
                    "role": "reader"
                },
                "user_id": "ou_c186b6833e2d5faf2bc587e71ddabcef"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsPrimarysResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}