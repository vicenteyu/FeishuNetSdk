namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 删除会议室 事件体
/// <para>接口ID：7160517357591953411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_VcRoomDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.room.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "room": {
            "room_id": "omm_4de32cf10a4358788ff4e09e37ebbf9b"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcRoomDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}