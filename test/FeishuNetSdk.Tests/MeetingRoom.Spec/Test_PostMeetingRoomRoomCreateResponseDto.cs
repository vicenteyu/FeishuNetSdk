namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 创建会议室 响应体
/// <para>接口ID：6907569523177799681</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITNwYjLyUDM24iM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomRoomCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "room_id":"omb_8d020b12fe49e82847c2af3c193d5754"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomRoomCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}