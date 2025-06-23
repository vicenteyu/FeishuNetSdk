namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 模糊搜索词条 响应体
/// <para>接口ID：7016992864837353500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":{
        "entities":[
            {
                "id":"enterprise_402***21",
                "main_keys":[
                    {
                        "key":"飞书词典",
                        "display_status":{
                            "allow_highlight":true,
                            "allow_search":true
                        }
                    }
                ],
                "aliases":[
                    {
                        "key":"词典",
                        "display_status":{
                            "allow_highlight":true,
                            "allow_search":true
                        }
                    }
                ],
                "description":"词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通",
                "create_time":"1627540853",
                "creator":"ou_dc5227a2bdb*******b61e0b5aff99fe5",
                "update_time":"1627541853",
                "updater":"ou_dc5227a2bdb*******b61e0b5aff99fe5",
                "source":3,
                "related_meta":{
                    "abbreviations":[
                        {
                            "id":"enterprise_445**90"
                        },
                        {
                            "id":"enterprise_70348****374354564"
                        },
                        {
                            "id":"enterprise_7036***993106796547"
                        }
                    ],
                    "chats":[
                        {
                            "id":"oc_c13831833****c92c52befa759ea4806"
                        },
                        {
                            "id":"oc_c8161c910****a24127e73b10233b295"
                        }
                    ],
                    "docs":[
                        {
                            "title":"猜你想问 / FAQs",
                            "url":"https://bytedance.feishu.cn/wiki/wikcnZ8Lq4f9DMCDOtdcIzCUjAh"
                        },
                        {
                            "title":"快速了解飞书文档 | Introducing Feishu Docs",
                            "url":"https://bytedance.feishu.cn/docs/doccnxlVCCFjMsJE15I7PLAjIWc"
                        }
                    ],
                    "links":[
                        {
                            "title":"飞书官网",
                            "url":"https://feishu.cn"
                        }
                    ],
                    "oncalls":[
                        {
                            "id":"7023689049****48034"
                        },
                        {
                            "id":"7024063787****10850"
                        }
                    ],
                    "users":[
                        {
                            "id":"ou_30b07b63089****518789914dac63d36",
                            "title":"负责人"
                        },
                        {
                            "id":"ou_b292c0d285c****4639fa4501e80c36a",
                            "title":""
                        }
                    ],
                    "classifications":[
                        {
                            "id":"704960692670****761",
                            "father_id":"704960692670****777"
                        }
                    ],
                    "images":[
                        {
                            "token":"boxbcEcmKi****HvgqWTpvdc7jc"
                        }
                    ]
                },
                "statistics":{
                    "like_count":100,
                    "dislike_count":20
                },
                "outer_info":{
                    "provider":"星云",
                    "outer_id":"client_6539***98d"
                },
                "rich_text":"词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通"
            }
        ],
        "page_token":"b152fa6e6f62a291019a04c3a93f36****c641910506ff15ff4cad6534e087cb4ed8fa2c"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostBaikeV1EntitiesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}