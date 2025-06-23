namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 删除日程参与人 请求体
/// <para>接口ID：6952888507002830875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "attendee_ids": [
        "user_xxxxx"
    ],
    "delete_ids": [
        {
            "type": "user",
            "user_id": "ou_xxxxxxxx",
            "chat_id": "oc_xxxxxxxxx",
            "room_id": "omm_xxxxxxxx",
            "third_party_email": "wangwu@email.com"
        }
    ],
    "need_notification": false,
    "instance_start_time_admin": "1647320400",
    "is_enable_admin": false
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}