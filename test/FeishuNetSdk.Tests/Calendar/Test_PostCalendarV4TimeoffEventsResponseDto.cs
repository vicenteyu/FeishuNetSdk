namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建请假日程 响应体
/// <para>接口ID：6952888507003142171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/timeoff_event/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ftimeoff_event%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4TimeoffEventsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "timeoff_event_id": "timeoff:XXXXXX-XXXX-0917-1623-aa493d591a39-XXXXXX",
        "user_id": "ou_XXXXXXXXXX",
        "timezone": "Asia/Shanghai",
        "start_time": "2021-01-01",
        "end_time": "2021-01-01",
        "title": "请假中(全天) / 1-Day Time Off",
        "description": "若删除此日程，飞书中相应的“请假”标签将自动消失，而请假系统中的休假申请不会被撤销。"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4TimeoffEventsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}