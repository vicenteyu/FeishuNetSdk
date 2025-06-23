namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 删除会议室层级 事件体
/// <para>接口ID：7194805625628082179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_VcRoomLevelDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.room_level.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "room_level_id": "omb_8d020b12fe49e82847c2af3c193d5754",
        "delete_child": false
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcRoomLevelDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}