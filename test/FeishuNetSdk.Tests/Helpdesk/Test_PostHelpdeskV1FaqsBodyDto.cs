// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1FaqsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建知识库 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 创建知识库 请求体
/// <para>接口ID：6955768699895791618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1FaqsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "faq": {
        "category_id": "6836004780707807251",
        "question": "问题",
        "answer": "答案",
        "answer_richtext": "[{\"content\":\"答案\",\"type\":\"text\"},{\"content\":\"这只是一个测试，医保问题\",\"type\":\"text\"}]",
        "tags": [
            "问",
            "题"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1FaqsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}