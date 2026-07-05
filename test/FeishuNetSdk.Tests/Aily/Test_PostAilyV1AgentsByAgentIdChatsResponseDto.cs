// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostAilyV1AgentsByAgentIdChatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发起智能体对话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 发起智能体对话 响应体
/// <para>接口ID：7646811253679819955</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AgentsByAgentIdChatsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_chat_id": "7640186506971926032"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1AgentsByAgentIdChatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}