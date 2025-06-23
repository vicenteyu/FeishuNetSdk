namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 离职信息变更 事件体
/// <para>接口ID：7372168594387828740</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/resignation-events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrOffboardingUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.offboarding.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "tenant_id": "7072306364927985196",
        "offboarding_info_id": "7072306364927985196",
        "process_id": "7072306364927985196",
        "checklist_process_id": "7072306364927985196",
        "employment_id": "7072306364927985196",
        "operator": "7072306364927985196",
        "status": 1,
        "checklist_status": 1,
        "updated_time": "1714985958000",
        "updated_fields": [
            "offboarding_date"
        ],
        "target_user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrOffboardingUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}