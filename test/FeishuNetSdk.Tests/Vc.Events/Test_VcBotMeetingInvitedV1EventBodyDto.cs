// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_VcBotMeetingInvitedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 邀请机器人入会 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 邀请机器人入会 事件体
/// <para>接口ID：7672664994766949623</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_invited</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_invited</para>
/// </summary>
[TestClass]
public class Test_VcBotMeetingInvitedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.bot.meeting_invited_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "meeting": {
            "id": "7628148899983674909",
            "topic": "周会",
            "meeting_no": "123456789",
            "start_time": "1712345678",
            "end_time": "1712349278",
            "host_user": {
                "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                "user_type": 1,
                "user_role": 1,
                "user_name": "张三"
            }
        },
        "bot": {
            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
            "user_type": 1,
            "user_role": 1,
            "user_name": "张三"
        },
        "inviter": {
            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
            "user_type": 1,
            "user_role": 1,
            "user_name": "张三"
        },
        "invite_time": "1712345678",
        "call_id": "7c9e6679-7425-40de-944b-e07fc1f90ae7"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcBotMeetingInvitedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}