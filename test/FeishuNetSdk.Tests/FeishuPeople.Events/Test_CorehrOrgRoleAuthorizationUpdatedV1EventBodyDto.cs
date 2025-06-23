namespace FeishuNetSdk.Tests.FeishuPeople.Events;

/// <summary>
/// 测试 【事件】组织角色授权变更 事件体
/// <para>接口ID：7188912476535488540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2forg_role_authorization%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrOrgRoleAuthorizationUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.org_role_authorization.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "role_id": "7072306364927985196",
        "management_scope_list": [
            {
                "management_dimension": "department",
                "obj_id": "7023318326176777742"
            }
        ],
        "employment_id_list": [
            "707230636492884196,748383458492845524"
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.FeishuPeople.Events.CorehrOrgRoleAuthorizationUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}