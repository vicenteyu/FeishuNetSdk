// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1AgentSkillsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建客服技能 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建客服技能 响应体
/// <para>接口ID：6955768425688268803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent_skill/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent_skill%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1AgentSkillsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_skill_id": "test-skill-id"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1AgentSkillsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}