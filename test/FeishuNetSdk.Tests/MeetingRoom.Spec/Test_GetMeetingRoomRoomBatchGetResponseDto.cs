// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMeetingRoomRoomBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询会议室详情 响应体
/// <para>接口ID：6907569523177766913</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/query-meeting-room-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDOyUjLxgjM14SM4ITN</para>
/// </summary>
[TestClass]
public class Test_GetMeetingRoomRoomBatchGetResponseDto : TestBase
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
                "building_id":"omb_8ec170b937536a5d87c23b418b83f9bb",
                "building_name":"Building name",
                "capacity":14,
                "description":"Some description",
                "display_id":"FM537532166",
                "floor_name":"F1",
                "is_disabled":false,
                "name":"Room name"
            },
            {
                "room_id":"omm_83d09ad4f6896e02029a6a075f71c9d1",
                "building_id":"omb_38570e4f0fd9ecf15030d3cc8b388f3a",
                "building_name":"Building name_2",
                "capacity":12,
                "description":"Some description",
                "display_id":"FM746810530",
                "floor_name":"F15",
                "is_disabled":false,
                "name":"Room name_2"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.GetMeetingRoomRoomBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}