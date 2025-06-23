namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 录制完成 事件体
/// <para>接口ID：6960861158128959491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/events/recording_ready</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fevents%2frecording_ready</para>
/// </summary>
[TestClass]
public class Test_VcMeetingRecordingReadyV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.meeting.recording_ready_v1",
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
            "owner": {
                "id": {
                    "union_id": "on_8ed6aa67826108097d9ee143816345",
                    "user_id": "e33ggbyz",
                    "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                }
            }
        },
        "url": "https://meetings.feishu.cn/minutes/obcn37dxcftoc3656rgyejm7",
        "duration": "30000"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcMeetingRecordingReadyV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}