namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询会议室ID 响应体
/// <para>接口ID：6907569745299767298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-meeting-room-id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzMxYjL2MTM24iNzEjN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomRoomBatchGetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "rooms":[
            {
                "room_id":"omm_eada1d61a550955240c28757e7dec3af",
                "custom_room_id":"test01"
            },
            {
                "room_id":"omm_83d09ad4f6896e02029a6a075f71c9d1",
                "custom_room_id":"test02"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomRoomBatchGetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}