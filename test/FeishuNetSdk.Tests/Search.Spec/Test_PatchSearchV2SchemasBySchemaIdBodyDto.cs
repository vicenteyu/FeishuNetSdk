namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 修改数据范式 请求体
/// <para>接口ID：7100866111462211612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/schema/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fschema%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSearchV2SchemasBySchemaIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "display": {
        "card_key": "search_common_card",
        "fields_mapping": [
            {
                "data_field": "${description}",
                "display_field": "summary"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Search.Spec.PatchSearchV2SchemasBySchemaIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}