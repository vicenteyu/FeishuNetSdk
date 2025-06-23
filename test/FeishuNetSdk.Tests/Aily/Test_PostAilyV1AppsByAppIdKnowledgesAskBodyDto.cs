namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 执行数据知识问答 请求体
/// <para>接口ID：7424752773160779780</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/ask</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-knowledge%2fask</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AppsByAppIdKnowledgesAskBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "message": {
        "content": "推荐一部电影"
    },
    "data_asset_ids": [
        "asset_aadg2b5os5wjg"
    ],
    "data_asset_tag_ids": [
        "spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1AppsByAppIdKnowledgesAskBodyDto>(json);
        Assert.IsNotNull(result);
    }
}