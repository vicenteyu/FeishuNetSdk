// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1MessageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 服务台机器人向工单绑定的群内发送消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 服务台机器人向工单绑定的群内发送消息 响应体
/// <para>接口ID：7036209421748764675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fbot-message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1MessageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "om_7054301238434"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.PostHelpdeskV1MessageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}