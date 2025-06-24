// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMeetingRoomSummaryBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室日程主题和会议详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.MeetingRoom.Spec;

/// <summary>
/// 测试 查询会议室日程主题和会议详情 响应体
/// <para>接口ID：6922096654371831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjM5UjLyITO14iMykTN%2f</para>
/// </summary>
[TestClass]
public class Test_PostMeetingRoomSummaryBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "ErrorEventUids": [],
        "EventInfos": [
            {
                "original_time": 0,
                "summary": "test",
                "uid": "a04dbea1-86b9-4372-aa8d-64ebe801be2a",
                "vchat": {
                    "meeting_url": "https://vc.feishu.cn/j/935314044",
                    "vc_type": "vc"
                }
            },
            {
                "original_time": 0,
                "summary": "日程",
                "uid": "d7a44c9b-7ae0-4a97-bf80-b4f050cedffa",
                "vchat": {
                    "meeting_url": "https://vc.feishu.cn/j/777110140",
                    "vc_type": "vc"
                }
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.MeetingRoom.Spec.PostMeetingRoomSummaryBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}