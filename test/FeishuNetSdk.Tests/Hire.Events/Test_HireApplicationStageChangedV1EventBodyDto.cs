namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 投递阶段变更 事件体
/// <para>接口ID：7385118058418896900</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/application/events/stage_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fevents%2fstage_changed</para>
/// </summary>
[TestClass]
public class Test_HireApplicationStageChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.application.stage_changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "application_id": "6891470273284114702",
        "origin_stage_id": "6891470273281123213",
        "target_stage_id": "6891470273281123214",
        "update_time": 1652806656258
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireApplicationStageChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}