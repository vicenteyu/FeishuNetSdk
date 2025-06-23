namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 获取数据范式 响应体
/// <para>接口ID：7100866111462178844</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/schema/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fschema%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSearchV2SchemasBySchemaIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "schema": {
            "display": {
                "card_key": "search_common_card",
                "fields_mapping": [
                    {
                        "data_field": "${priority}",
                        "display_field": "tag1"
                    },
                    {
                        "data_field": "${description}",
                        "display_field": "summary"
                    }
                ]
            },
            "properties": [
                {
                    "is_returnable": true,
                    "is_searchable": true,
                    "name": "description",
                    "search_options": {
                        "enable_camel_match": false,
                        "enable_exact_match": false,
                        "enable_number_suffix_match": false,
                        "enable_prefix_match": false,
                        "enable_semantic_match": true
                    },
                    "type": "text"
                },
                {
                    "is_returnable": true,
                    "name": "icon_url",
                    "type": "text"
                },
                {
                    "name": "rank",
                    "sort_options": {
                        "order": "asc"
                    },
                    "type": "int"
                },
                {
                    "is_returnable": true,
                    "name": "priority",
                    "type": "tag",
                    "type_definitions": {
                        "tag": [
                            {
                                "color": "red",
                                "name": "type",
                                "text": "type"
                            }
                        ]
                    }
                }
            ],
            "schema_id": "example_schema"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.Spec.GetSearchV2SchemasBySchemaIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}