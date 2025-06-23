namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 回复会议室日程实例 请求体
/// <para>接口ID：6907569745299226626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/reply-meeting-room-event-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN4UjL2cDO14iN3gTN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomInstanceReplyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
        "room_id":"omm_c7e9ef91ec9f3c007f1dfb2503918981",
        "uid":"bff6b51f-b7c1-40c6-b8ef-aef966c9ffc7",
        "original_time":0,
        "status":"NOT_CHECK_IN"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomInstanceReplyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}