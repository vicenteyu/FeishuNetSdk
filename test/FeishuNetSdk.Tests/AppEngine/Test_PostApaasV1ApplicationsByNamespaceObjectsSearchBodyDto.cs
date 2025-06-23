namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 搜索记录 请求体
/// <para>接口ID：7384730094873051164</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "q": "搜索关键字",
    "search_objects": [
        {
            "api_name": "_user",
            "search_fields": [
                "_id"
            ],
            "select": [
                "_id"
            ],
            "filter": {
                "conditions": [
                    {
                        "index": "1",
                        "left": {
                            "type": "metadataVariable",
                            "settings": "{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}"
                        },
                        "right": {
                            "type": "constant",
                            "settings": "{\"fieldPath\":[{\"fieldApiName\": \"_id\",\"objectApiName\": \"_user\"}]}"
                        },
                        "operator": "equal"
                    }
                ],
                "logic_expression": "1 and 2"
            },
            "order_by": {
                "field": "_id",
                "order_type": "asc"
            }
        }
    ],
    "page_token": "eyJvYmplY3RzX3BhZ2VfdG9rZW4iOlt7Im9ial9pZCI6MTc2OTI4NzM5M",
    "page_size": "100",
    "metadata": "Label"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}