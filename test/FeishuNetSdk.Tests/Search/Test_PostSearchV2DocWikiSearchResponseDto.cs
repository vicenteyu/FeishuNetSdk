// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-11
// ************************************************************************
// <copyright file="Test_PostSearchV2DocWikiSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 搜索文档 响应体
/// <para>接口ID：7589313298248600535</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/doc_wiki/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdoc_wiki%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2DocWikiSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "total": 100,
        "has_more": true,
        "res_units": [
            {
                "title_highlighted": "<h>飞书文档</h>使用指南",
                "summary_highlighted": "本文介绍<h>飞书文档</h>的创建、编辑与分享功能",
                "entity_type": "DOC",
                "result_meta": {
                    "doc_types": "SHORTCUT",
                    "update_time": 1766567446,
                    "url": "https://www.feishu.cn/docs/dox-1234567890abcdef",
                    "owner_name": "张三",
                    "owner_id": "ou-7890123456abcdef",
                    "is_cross_tenant": false,
                    "create_time": 1766567446,
                    "last_open_time": 1766567446,
                    "edit_user_id": "ou-1122334455aabbcc",
                    "edit_user_name": "李四",
                    "token": "dox_9876543210fedcba"
                }
            }
        ],
        "page_token": "token_1234567890fedcba"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.PostSearchV2DocWikiSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}