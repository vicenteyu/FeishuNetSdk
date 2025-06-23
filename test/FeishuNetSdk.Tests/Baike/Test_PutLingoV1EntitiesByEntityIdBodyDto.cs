namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 更新免审词条 请求体
/// <para>接口ID：7249689905697128476</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutLingoV1EntitiesByEntityIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
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
                "id": "ou_30b07b6****ea46518789914dac63d36",
                "title": "负责人"
            },
            {
                "id": "ou_b292c0****c14754639fa4501e80c36a",
                "title": ""
            }
        ],
        "chats": [
            {
                "id": "oc_c13831833e****92c52befa759ea4806"
            },
            {
                "id": "oc_c8161c910****a24127e73b10233b295"
            }
        ],
        "docs": [
            {
                "title": "猜你想问 / FAQs",
                "url": "https://example.feishu.cn/wiki/wikcnZ8Lq4f9DMCDOtdcIzCUjAh"
            },
            {
                "title": "快速了解飞书文档 | Introducing Feishu Docs",
                "url": "https://example.feishu.cn/docs/doccnxlVCCFjMsJE15I7PLAjIWc"
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
                "id": "702368904****548034"
            },
            {
                "id": "70240637****0910850"
            }
        ],
        "abbreviations": [
            {
                "id": "enterprise_44***90"
            },
            {
                "id": "enterprise_70348****374354564"
            },
            {
                "id": "enterprise_70365****3106796547"
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
                "token": "boxbcEcmKiD3SGHvgqWTpvdc7jc"
            }
        ]
    },
    "outer_info": {
        "provider": "星云",
        "outer_id": "client_653****98d"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PutLingoV1EntitiesByEntityIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}