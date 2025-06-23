namespace FeishuNetSdk.Tests.Acs.Events;

/// <summary>
/// 测试 用户信息变更 事件体
/// <para>接口ID：6987691292973907969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_AcsUserUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "acs.user.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "card": 123456,
        "face_uploaded": true
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Acs.Events.AcsUserUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}