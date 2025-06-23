namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 删除会议室 请求体
/// <para>接口ID：6907569523177750529</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/delete-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUzMxYjL1MTM24SNzEjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomRoomDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "room_id":"omb_8d020b12fe49e82847c2af3c193d5754"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomRoomDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}