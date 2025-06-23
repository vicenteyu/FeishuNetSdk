namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 员工完成转正 事件体
/// <para>接口ID：7085202007996514308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/probation/converted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fconverted</para>
/// </summary>
[TestClass]
public class Test_CorehrEmploymentConvertedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.employment.converted_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "employment_id": "7072306364927985196"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrEmploymentConvertedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}