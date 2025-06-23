namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建客服技能 请求体
/// <para>接口ID：6955768425688268803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1AgentSkillsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "部门技能",
    "rules": [
        {
            "id": "12",
            "selected_operator": 8,
            "operand": {
                "selected_departments": [
                    {
                        "id": "部门ID",
                        "name": "IT"
                    }
                ]
            }
        }
    ],
    "agent_ids": [
        "客服ID"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1AgentSkillsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}