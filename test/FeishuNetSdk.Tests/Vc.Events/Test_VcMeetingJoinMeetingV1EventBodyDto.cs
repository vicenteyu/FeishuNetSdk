// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_VcMeetingJoinMeetingV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 加入会议 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 加入会议 事件体
/// <para>接口ID：6960861158128893955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/events/join_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fevents%2fjoin_meeting</para>
/// </summary>
[TestClass]
public class Test_VcMeetingJoinMeetingV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.meeting.join_meeting_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "meeting": {
            "id": "6911188411934433028",
            "topic": "my meeting",
            "meeting_no": "235812466",
            "start_time": "1608883322",
            "end_time": "1608883899",
            "host_user": {
                "id": {
                    "union_id": "on_8ed6aa67826108097d9ee143816345",
                    "user_id": "e33ggbyz",
                    "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                },
                "user_role": 1,
                "user_type": 1
            },
            "owner": {
                "id": {
                    "union_id": "on_8ed6aa67826108097d9ee143816345",
                    "user_id": "e33ggbyz",
                    "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                },
                "user_role": 1,
                "user_type": 1
            }
        },
        "operator": {
            "id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "user_role": 1,
            "user_type": 1
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcMeetingJoinMeetingV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}