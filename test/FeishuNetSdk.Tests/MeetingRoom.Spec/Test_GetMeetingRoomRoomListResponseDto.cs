namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 获取会议室列表 响应体
/// <para>接口ID：6907569742384889858</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-meeting-room-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADOyUjLwgjM14CM4ITN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomRoomListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "page_token":"1",
        "has_more":true,
        "rooms":[
            {
                "room_id":"omm_eada1d61a550955240c28757e7dec3af",
                "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
                "building_name":"Building name",
                "capacity":14,
                "description":"Some description",
                "display_id":"FM537532166",
                "floor_name":"F1",
                "is_disabled":false,
                "name":"Room name"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomRoomListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}