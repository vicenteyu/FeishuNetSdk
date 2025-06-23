namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 创建免审词条 响应体
/// <para>接口ID：7085379347152044034</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1EntitiesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "entity": {
            "id": "enterprise_40217521",
            "main_keys": [
                {
                    "key": "飞书词典,
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
            "create_time": "1627540853",
            "update_time": "1627541853",
            "related_meta": {
                "abbreviations": [
                    {
                        "id": "enterprise_4450890"
                    },
                    {
                        "id": "enterprise_703481393374354564"
                    },
                    {
                        "id": "enterprise_7036598993106796547"
                    }
                ],
                "chats": [
                    {
                        "id": "oc_c13831833eaa8c92c52befa759ea4806"
                    },
                    {
                        "id": "oc_c8161c9109966a24127e73b10233b295"
                    }
                ],
                "docs": [
                    {
                        "title": "猜你想问 / FAQs",
                        "url": "https://bytedance.feishu.cn/wiki/wikcnZ8Lq4f9DMCDOtdcIzCUjAh"
                    },
                    {
                        "title": "快速了解飞书文档 | Introducing Feishu Docs",
                        "url": "https://bytedance.feishu.cn/docs/doccnxlVCCFjMsJE15I7PLAjIWc"
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
                        "id": "7023689049445548034"
                    },
                    {
                        "id": "7024063787560910850"
                    }
                ],
                "users": [
                    {
                        "id": "ou_30b07b63089ea46518789914dac63d36",
                        "title": "负责人"
                    },
                    {
                        "id": "ou_b292c0d285c14754639fa4501e80c36a",
                        "title": ""
                    }
                ],
                "classifications": [
                    {
                        "id": "7049606926702837761",
                        "father_id": "7049606926702837777"
                    }
                ],
                "images": [
                    {
                        "token": "boxbcEcmKiD3SGHvgqWTpvdc7jc"
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
            "rich_text": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostBaikeV1EntitiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}