namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 获取词条详情 响应体
/// <para>接口ID：7016992864837304348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fget</para>
/// </summary>
[TestClass]
public class Test_GetBaikeV1EntitiesByEntityIdResponseDto : TestBase
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
            "id": "enterprise_402***21",
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
            "create_time": "1627540853",
            "update_time": "1627541853",
            "related_meta": {
                "abbreviations": [
                    {
                        "id": "enterprise_44***90"
                    },
                    {
                        "id": "enterprise_703481***374354564"
                    },
                    {
                        "id": "enterprise_703659***3106796547"
                    }
                ],
                "chats": [
                    {
                        "id": "oc_c13831833e***c92c52befa759ea4806"
                    },
                    {
                        "id": "oc_c8161c910996****127e73b10233b295"
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
                        "id": "7023689049445****34"
                    },
                    {
                        "id": "702406378756***0850"
                    }
                ],
                "users": [
                    {
                        "id": "ou_30b07b63089****518789914dac63d36",
                        "title": "负责人"
                    },
                    {
                        "id": "ou_b292c0d285c****4639fa4501e80c36a",
                        "title": ""
                    }
                ],
                "classifications": [
                    {
                        "id": "7049606926****37761",
                        "father_id": "7049606926****37777"
                    }
                ],
                "images": [
                    {
                        "token": "boxbcEcmKi***GHvgqWTpvdc7jc"
                    }
                ]
            },
            "statistics": {
                "like_count": 100,
                "dislike_count": 20
            },
            "outer_info": {
                "provider": "星云",
                "outer_id": "client_6539***98d"
            },
            "rich_text": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.GetBaikeV1EntitiesByEntityIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}