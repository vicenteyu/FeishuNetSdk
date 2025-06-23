namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 删除公司 事件体
/// <para>接口ID：7423693709786071043</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_CorehrCompanyDeletedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.company.deleted_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "company_id": "6969828847121885087"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrCompanyDeletedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}