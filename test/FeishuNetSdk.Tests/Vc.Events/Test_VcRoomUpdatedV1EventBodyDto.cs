namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 更新会议室 事件体
/// <para>接口ID：7160517356095881220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_VcRoomUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.room.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "room": {
            "room_id": "omm_4de32cf10a4358788ff4e09e37ebbf9b",
            "name": "测试会议室",
            "capacity": 10,
            "description": "测试会议室描述",
            "display_id": "LM134742334",
            "custom_room_id": "1234",
            "room_level_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
            "path": [
                "omb_4ad1a2c7a2fbc5fc9570f38456931293"
            ],
            "room_status": {
                "status": true,
                "schedule_status": true,
                "disable_start_time": "1652356050",
                "disable_end_time": "1652442450",
                "disable_reason": "测试占用",
                "contact_ids": [
                    {
                        "union_id": "on_785a8cda5345f665f7187d7d876cb790",
                        "user_id": "f3e15a6a",
                        "open_id": "ou_2cc0462a0597358575e771bea74e3304"
                    }
                ],
                "disable_notice": true,
                "resume_notice": true
            },
            "device": [
                {
                    "name": "电话"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcRoomUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}