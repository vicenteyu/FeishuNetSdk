namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 流程实例状态变化 事件体
/// <para>接口ID：7397629009809866780</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-status%2fevents%2fupdate</para>
/// </summary>
[TestClass]
public class Test_CorehrProcessStatusUpdateV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.process.status.update_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "process_id": "7072306364927985196",
        "status": 1,
        "biz_type": "renewal_record",
        "flow_definition_id": "people_7023711013443944467_7379576600867884844v",
        "properties": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrProcessStatusUpdateV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}