// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostAilyV1AgentsByAgentIdSessionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 创建会话 请求体
/// <para>接口ID：7657118382231555265</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AgentsByAgentIdSessionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "计算问题"
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1AgentsByAgentIdSessionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}