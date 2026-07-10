// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="Test_PostAilyV1AgentsByAgentIdSessionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建会话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 创建会话 响应体
/// <para>接口ID：7657118382231555265</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AgentsByAgentIdSessionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "session_id": "conversation_4kj6xxrp2jqk2",
        "name": "新会话",
        "created_at": "1783424638072"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1AgentsByAgentIdSessionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}