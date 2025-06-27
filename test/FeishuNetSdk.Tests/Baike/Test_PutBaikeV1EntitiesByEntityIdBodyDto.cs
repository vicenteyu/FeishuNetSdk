// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutBaikeV1EntitiesByEntityIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新免审词条 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 更新免审词条 请求体
/// <para>接口ID：7085379347152060418</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBaikeV1EntitiesByEntityIdBodyDto : TestBase
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
    "related_meta": {
        "abbreviations": [
            {
                "id": "enterprise_445***90"
            },
            {
                "id": "enterprise_7034***93374354564"
            },
            {
                "id": "enterprise_70365***93106796547"
            }
        ],
        "chats": [
            {
                "id": "oc_c13831833e****92c52befa759ea4806"
            },
            {
                "id": "oc_c8161c9109****24127e73b10233b295"
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
                "id": "70236890494****8034"
            },
            {
                "id": "70240637875****0850"
            }
        ],
        "users": [
            {
                "id": "ou_30b07b630****46518789914dac63d36",
                "title": "负责人"
            },
            {
                "id": "ou_b292c0d2****4754639fa4501e80c36a",
                "title": ""
            }
        ],
        "classifications": [
            {
                "id": "7049606926702837761",
                "father_id": "7049606926****37777"
            }
        ],
        "images": [
            {
                "token": "boxbcEcmKi****HvgqWTpvdc7jc"
            }
        ]
    },
    "outer_info": {
        "provider": "星云",
        "outer_id": "client_6539***98d"
    },
    "rich_text": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PutBaikeV1EntitiesByEntityIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}