// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_MeetingRoomMeetingRoomDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 会议室删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Events;

/// <summary>
/// 测试 会议室删除 事件体
/// <para>接口ID：7056983069833035780</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmeeting_room-v1%2fmeeting_room%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_MeetingRoomMeetingRoomDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "meeting_room.meeting_room.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "room_name": "room1",
        "room_id": "omb_8d020b12fe49e82847c2af3c193d5754"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.MeetingRoom.Events.MeetingRoomMeetingRoomDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}