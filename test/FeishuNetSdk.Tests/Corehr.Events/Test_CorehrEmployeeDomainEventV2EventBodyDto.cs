namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 人员信息变更 事件体
/// <para>接口ID：7350263010596438044</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/events/domain_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fevents%2fdomain_event</para>
/// </summary>
[TestClass]
public class Test_CorehrEmployeeDomainEventV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.employee.domain_event_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "event_type": 1,
        "sub_event_type": 1001,
        "operator_user_id": "7216228370772919852",
        "opt_scene": "OpenAPIAddEmployee",
        "opt_desc": "开放平台创建任职记录V1接口入职员工",
        "opt_time": "1697701824",
        "opt_id": "7291571779879978540",
        "employment_id": "7324965529786844716",
        "data": [
            {
                "id": "7291573441955235372",
                "entity": "email",
                "agg_entity": "person",
                "agg_entity_id": "7291273149417948716",
                "opt_type": 1,
                "fields": [
                    "fields apiname"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrEmployeeDomainEventV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}