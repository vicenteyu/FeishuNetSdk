// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMeetingRoomSummaryBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室日程主题和会议详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询会议室日程主题和会议详情 请求体
/// <para>接口ID：6922096654371831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjM5UjLyITO14iMykTN%2f</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomSummaryBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "EventUids":[
        {
            "uid":"a04dbea1-86b9-4372-aa8d-64ebe801be2a",
            "original_time":0
        },
        {
            "uid":"d7a44c9b-7ae0-4a97-bf80-b4f050cedffa",
            "original_time":0
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomSummaryBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}