// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBaikeV1DraftsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建草稿 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 创建草稿 请求体
/// <para>接口ID：7016992864837271580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/draft/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fdraft%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1DraftsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "enterprise_40217521",
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
            "key": "飞书词典",
            "display_status": {
                "allow_highlight": true,
                "allow_search": true
            }
        }
    ],
    "description": "词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通",
    "related_meta": {
        "users": [
            {
                "id": "格式请看请求体示例",
                "title": "飞书词典帮助中心"
            }
        ],
        "chats": [
            {
                "id": "格式请看请求体示例"
            }
        ],
        "docs": [
            {
                "title": "飞书词典帮助中心",
                "url": "https://www.feishu.cn/hc/zh-CN"
            }
        ],
        "oncalls": [
            {
                "id": "格式请看请求体示例"
            }
        ],
        "links": [
            {
                "title": "飞书词典帮助中心",
                "url": "https://www.feishu.cn/hc/zh-CN"
            }
        ],
        "abbreviations": [
            {
                "id": "enterprise_51527260"
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
                "token": "boxbcEcmKiDia3evgqWTpvdc7jc"
            }
        ]
    },
    "outer_info": {
        "provider": "星云",
        "outer_id": "client_653267498d"
    },
    "rich_text": "&lt;b&gt;加粗&lt;/b&gt;&lt;i&gt;斜体&lt;/i&gt;&lt;p&gt;&lt;a href=\"https://feishu.cn\"&gt;链接&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;span&gt;词典是飞书提供的一款知识管理工具，通过飞书词典可以帮助企业将分散的知识信息进行聚合，并通过UGC的方式，促进企业知识的保鲜和流通&lt;/span&gt;&lt;/p&gt;"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostBaikeV1DraftsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}