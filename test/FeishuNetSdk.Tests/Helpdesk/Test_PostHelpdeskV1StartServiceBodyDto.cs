// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1StartServiceBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建服务台对话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建服务台对话 请求体
/// <para>接口ID：6955768699895726082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/start_service</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fstart_service</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1StartServiceBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "human_service": false,
    "appointed_agents": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ],
    "open_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "customized_info": "测试自定义字段信息"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1StartServiceBodyDto>(json);
        Assert.IsNotNull(result);
    }
}