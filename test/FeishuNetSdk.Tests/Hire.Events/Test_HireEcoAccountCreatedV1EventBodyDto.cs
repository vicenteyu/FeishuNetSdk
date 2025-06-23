namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 账号绑定 事件体
/// <para>接口ID：7195815979079417857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_HireEcoAccountCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.eco_account.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "scope": 1,
        "account_id": "6931286400470354183",
        "account_name": "背调账号 001",
        "usage_list": [
            1
        ],
        "custom_field_list": [
            {
                "key": "ord_id",
                "value": "7233333"
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireEcoAccountCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}