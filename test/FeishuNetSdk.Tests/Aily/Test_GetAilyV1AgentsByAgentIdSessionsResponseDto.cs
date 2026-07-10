// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="Test_GetAilyV1AgentsByAgentIdSessionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会话列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 查询会话列表 响应体
/// <para>接口ID：7657118382231506113</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_chat_session/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_chat_session%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AgentsByAgentIdSessionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "sessions": [
            {
                "session_id": "conversation_sadcadcds2",
                "name": "question",
                "status": "done",
                "created_at": 1783428305028,
                "last_chat_at": 1783428305028
            }
        ],
        "has_more": true,
        "next_page_token": "1783425184259422"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AgentsByAgentIdSessionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}