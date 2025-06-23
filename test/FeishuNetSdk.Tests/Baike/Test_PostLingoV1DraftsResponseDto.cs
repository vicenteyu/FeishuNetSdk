namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 创建草稿 响应体
/// <para>接口ID：7249689905697046556</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/draft/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fdraft%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1DraftsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "draft": {
            "draft_id": "54567***567897",
            "entity": {
                "id": "enterprise_40****21",
                "main_keys": [
                    {
                        "key": "飞书词典",
                        "display_status": {
                            "allow_highlight": true,
                            "allow_search": true
                        }
                    }
                ],
                "aliases": [
                    {
                        "key": "词典",
                        "display_status": {
                            "allow_highlight": true,
                            "allow_search": true
                        }
                    }
                ],
                "description": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通",
                "rich_text": "<p>词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通</p>",
                "i18n_descs": [
                    {
                        "language": 1,
                        "description": "国际化中文释义",
                        "rich_text": "<p>国际化中文释义</p>"
                    }
                ],
                "related_meta": {
                    "users": [
                        {
                            "id": "ou_30b07b63089e***18789914dac63d36",
                            "title": "负责人"
                        },
                        {
                            "id": "ou_b292c0d285c1***639fa4501e80c36a",
                            "title": ""
                        }
                    ],
                    "chats": [
                        {
                            "id": "oc_c13831833eaa8c92***cfa759ea4806"
                        },
                        {
                            "id": "oc_c8161c9109966a24***e73b10233b295"
                        }
                    ],
                    "docs": [
                        {
                            "title": "猜你想问 / FAQs",
                            "url": "https://example.feishu.cn/wiki/wikcnZ8Lq4***CDOtdcIzCUjAh"
                        },
                        {
                            "title": "快速了解飞书文档 | Introducing Feishu Docs",
                            "url": "https://example.feishu.cn/docs/doccnxlVCs***sJE15I7PLAjIWc"
                        }
                    ],
                    "links": [
                        {
                            "title": "飞书官网",
                            "url": "https://feishu.cn"
                        }
                    ],
                    "oncalls": [
                        {
                            "id": "70236890***45548034"
                        },
                        {
                            "id": "70240637***60910850"
                        }
                    ],
                    "abbreviations": [
                        {
                            "id": "enterprise_4450***890"
                        },
                        {
                            "id": "enterprise_703481***74354564"
                        },
                        {
                            "id": "enterprise_703659***06796547"
                        }
                    ],
                    "classifications": [
                        {
                            "id": "70496069***2837761",
                            "father_id": "70496069***02837777"
                        }
                    ],
                    "images": [
                        {
                            "token": "boxbcEcmKiD***vgqWTpvdc7jc"
                        }
                    ]
                },
                "statistics": {
                    "like_count": 100,
                    "dislike_count": 20
                },
                "outer_info": {
                    "provider": "星云",
                    "outer_id": "client_6539i3498d"
                },
                "create_time": "1627540853",
                "update_time": "1627541853"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostLingoV1DraftsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}