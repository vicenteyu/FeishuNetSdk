namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 创建会议室层级 事件体
/// <para>接口ID：7194805625628098563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_VcRoomLevelCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.room_level.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "room_level": {
            "room_level_id": "层级ID",
            "name": "测试层级",
            "parent_id": "omb_4ad1a2c7a2fbc5fc9570f38456931293",
            "path": [
                "omb_4ad1a2c7a2fbc5fc9570f38456931293"
            ],
            "has_child": false,
            "custom_group_id": "10000"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcRoomLevelCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}