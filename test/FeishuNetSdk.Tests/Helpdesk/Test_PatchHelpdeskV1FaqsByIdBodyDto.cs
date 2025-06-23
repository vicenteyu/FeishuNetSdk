namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 修改知识库 请求体
/// <para>接口ID：6955768699895676930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1FaqsByIdBodyDto : TestBase
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
        "answer_richtext": [
            {
                "content": "这是一个答案",
                "type": "text"
            }
        ],
        "tags": [
            "测试",
            "问题"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PatchHelpdeskV1FaqsByIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}