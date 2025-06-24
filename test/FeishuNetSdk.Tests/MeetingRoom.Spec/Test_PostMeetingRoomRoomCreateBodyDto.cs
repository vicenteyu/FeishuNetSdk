// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMeetingRoomRoomCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建会议室 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 创建会议室 请求体
/// <para>接口ID：6907569523177799681</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITNwYjLyUDM24iM1AjN</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomRoomCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "building_id":"omb_8d020b12fe49e82847c2af3c193d5754",
    "floor":"F1",
    "name":"测试会议室",
    "capacity":10,
    "is_disabled": false,
    "custom_room_id":"test_room_01"
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomRoomCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}