// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1TicketsByTicketIdAnswerUserQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回复用户在工单里的提问 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 回复用户在工单里的提问 请求体
/// <para>接口ID：6955768699895988226</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/answer_user_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fanswer_user_query</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1TicketsByTicketIdAnswerUserQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_id": "abcd",
    "faqs": [
        {
            "id": "12345",
            "score": 0.9
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1TicketsByTicketIdAnswerUserQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}