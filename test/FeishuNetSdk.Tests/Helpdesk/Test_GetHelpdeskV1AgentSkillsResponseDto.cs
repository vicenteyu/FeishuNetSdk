// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1AgentSkillsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询全部客服技能 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 查询全部客服技能 响应体
/// <para>接口ID：6955768425688285187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1AgentSkillsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_skills": [
            {
                "id": "test-skill-id",
                "name": "skill-name",
                "agent_ids": [
                    "ou_ea651a5c09e2d01af8acd34059f5359b"
                ],
                "is_default": false
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.GetHelpdeskV1AgentSkillsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}