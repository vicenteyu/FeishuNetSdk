namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询主日历日程忙闲信息 响应体
/// <para>接口ID：6952888507002912795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2flist</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4FreebusyListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "freebusy_list": [
            {
                "start_time": "2020-10-28T22:30:00+08:00",
                "end_time": "2020-10-28T22:45:00+08:00"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4FreebusyListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}