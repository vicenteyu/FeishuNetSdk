// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHelpdeskV1AgentsByAgentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新客服信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 更新客服信息 请求体
/// <para>接口ID：6974742353936842753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1AgentsByAgentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PatchHelpdeskV1AgentsByAgentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}