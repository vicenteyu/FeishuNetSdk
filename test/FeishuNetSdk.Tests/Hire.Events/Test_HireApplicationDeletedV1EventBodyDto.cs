namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 删除投递 事件体
/// <para>接口ID：7062313984436371457</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/event/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_HireApplicationDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.application.deleted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "application_ids": [
            "6914551145542568199"
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireApplicationDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}