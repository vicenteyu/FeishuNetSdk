namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询主日历信息 响应体
/// <para>接口ID：7051880392425439236</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/primary</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fprimary</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsPrimaryResponseDto : TestBase
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
                    "type": "shared",
                    "summary_alias": "日历备注名",
                    "is_deleted": false,
                    "is_third_party": false,
                    "role": "owner"
                },
                "user_id": "ou_xxxxxx"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsPrimaryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}