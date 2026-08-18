// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_VcBotMeetingStartedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 会议开始 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 会议开始 事件体
/// <para>接口ID：7672664994766933239</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_started</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_started</para>
/// </summary>
[TestClass]
public class Test_VcBotMeetingStartedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.bot.meeting_started_v1",
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
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "user_type": 1,
                "user_role": 1,
                "user_name": "张三"
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcBotMeetingStartedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}