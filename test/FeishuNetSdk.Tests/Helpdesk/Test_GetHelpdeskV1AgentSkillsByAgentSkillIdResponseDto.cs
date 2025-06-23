namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 查询指定客服技能 响应体
/// <para>接口ID：6955768425688481795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_skill": {
            "id": "test-skill-id",
            "name": "skill-name",
            "rules": [
                {
                    "id": "test-skill-id",
                    "selected_operator": 8,
                    "operator_options": [
                        7,
                        8
                    ],
                    "operand": {
                        "selected_departments": [
                            {
                                "id": "部门ID",
                                "name": "IT"
                            }
                        ]
                    },
                    "category": 3,
                    "display_name": "Chinese FAQs category"
                }
            ],
            "agent_ids": [
                "ou_ea651a5c09e2d01af8acd34059f5359b"
            ],
            "is_default": false,
            "agents": [
                {
                    "id": "ou_ea651a5c09e2d01af8acd34059f5359b",
                    "avatar_url": "https://avatar-url.com/test.png",
                    "name": "test-user"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1AgentSkillsByAgentSkillIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}