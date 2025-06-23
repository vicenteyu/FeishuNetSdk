namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 抄送单据状态变更 事件体
/// <para>接口ID：7296819819722539036</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/updated-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-cc%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrProcessCcUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.process.cc.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "process_id": "7072306364927985196",
        "approver_id": "7072306364927985187",
        "status": 5,
        "biz_type": "renewal_record"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrProcessCcUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}