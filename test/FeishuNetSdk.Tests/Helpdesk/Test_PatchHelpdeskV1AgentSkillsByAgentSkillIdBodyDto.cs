// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新客服技能 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 更新客服技能 请求体
/// <para>接口ID：6955768425688416259</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "agent_skill": {
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
                }
            }
        ],
        "agent_ids": [
            "ou_ea21d7f018e1155d960e40d33191f966"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PatchHelpdeskV1AgentSkillsByAgentSkillIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}