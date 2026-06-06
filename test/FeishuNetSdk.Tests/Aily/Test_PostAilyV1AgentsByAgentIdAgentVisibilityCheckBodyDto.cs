// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostAilyV1AgentsByAgentIdAgentVisibilityCheckBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取当前用户的可见性 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 获取当前用户的可见性 请求体
/// <para>接口ID：7646811253679836339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_visibility/check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_visibility%2fcheck</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AgentsByAgentIdAgentVisibilityCheckBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "channel_type": "web_sdk"
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1AgentsByAgentIdAgentVisibilityCheckBodyDto>(json);
        Assert.IsNotNull(result);
    }
}