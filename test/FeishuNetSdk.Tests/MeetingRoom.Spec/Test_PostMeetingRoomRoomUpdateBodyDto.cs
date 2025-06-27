// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMeetingRoomRoomUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新会议室 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 更新会议室 请求体
/// <para>接口ID：6907569524100694017</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/update-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMTNwYjLzUDM24yM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomRoomUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "room_id":"omb_8d020b12fe49e82847c2af3c193d5754",
    "name":"测试会议室",
    "capacity":10,
    "custom_room_id":"test_room_01"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomRoomUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}