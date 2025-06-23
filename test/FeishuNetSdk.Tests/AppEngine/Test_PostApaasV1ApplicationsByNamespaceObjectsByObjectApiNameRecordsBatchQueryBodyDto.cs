namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询记录列表 请求体
/// <para>接口ID：7384730094873067548</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "select": [
        "_name"
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
                    "settings": "{\"data\":\"123456\"}"
                },
                "operator": "equal"
            }
        ],
        "logic_expression": "1 and 2"
    },
    "order_by": [
        {
            "field": "_id",
            "direction": "ASC"
        }
    ],
    "group_by": [
        {
            "field": "_id"
        }
    ],
    "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
    "use_page_token": false,
    "page_size": 100,
    "offset": 0,
    "need_total_count": true
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}