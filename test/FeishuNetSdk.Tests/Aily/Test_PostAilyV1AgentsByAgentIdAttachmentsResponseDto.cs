// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostAilyV1AgentsByAgentIdAttachmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传附件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 上传附件 响应体
/// <para>接口ID：7646811253679787187</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_attachment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_attachment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AgentsByAgentIdAttachmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "agent_attachment_id": "3d058789-6952-4697-bf9c-1add1ebc206e"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1AgentsByAgentIdAttachmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}