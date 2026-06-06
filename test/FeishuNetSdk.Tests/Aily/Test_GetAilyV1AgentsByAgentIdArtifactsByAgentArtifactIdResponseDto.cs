// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_GetAilyV1AgentsByAgentIdArtifactsByAgentArtifactIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 下载智能体产物 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 下载智能体产物 响应体
/// <para>接口ID：7646811253679852723</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_artifact/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_artifact%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AgentsByAgentIdArtifactsByAgentArtifactIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_artifact": {
            "artifact_id": "artifact_4k6m2dbmrjeqf",
            "name": "cute_kitten.png",
            "url": "https://<bucket>.tos-cn-...volces.com/agent_runtime/artifact/.../dog2.png?X-Tos"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AgentsByAgentIdArtifactsByAgentArtifactIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}