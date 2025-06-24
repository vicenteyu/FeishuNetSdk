namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 更新草稿 请求体
/// <para>接口ID：7016992864837287964</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/draft/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fdraft%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBaikeV1DraftsByDraftIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
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
    "related_meta": {
        "abbreviations": [
            {
                "id": "enterprise_44***90"
            },
            {
                "id": "enterprise_703***393374354564"
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
                "id": "oc_c8161c9109***a24127e73b10233b295"
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
                "id": "702368904***5548034"
            },
            {
                "id": "702406378***0910850"
            }
        ],
        "users": [
            {
                "id": "ou_30b07b63089e***518789914dac63d36",
                "title": "负责人"
            },
            {
                "id": "ou_b292c0d285c****4639fa4501e80c36a",
                "title": ""
            }
        ],
        "classifications": [
            {
                "id": "704960692670****761",
                "father_id": "7049606926****37777"
            }
        ],
        "images": [
            {
                "token": "boxbcEcm****SGHvgqWTpvdc7jc"
            }
        ]
    },
    "rich_text": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PutBaikeV1DraftsByDraftIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}