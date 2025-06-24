// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1AgentSkillRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取客服技能列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 获取客服技能列表 响应体
/// <para>接口ID：6955768425688317955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill_rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1AgentSkillRulesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "rules": [
            {
                "id": "test-skill-id",
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
                "display_name": "中文知识库分类"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1AgentSkillRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}