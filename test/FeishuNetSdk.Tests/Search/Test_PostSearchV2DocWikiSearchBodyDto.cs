// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-11
// ************************************************************************
// <copyright file="Test_PostSearchV2DocWikiSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索文档 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 搜索文档 请求体
/// <para>接口ID：7589313298248600535</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/search-v2/doc_wiki/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdoc_wiki%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2DocWikiSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "飞书文档使用指南",
    "doc_filter": {
        "creator_ids": [
            "ou_789012"
        ],
        "doc_types": [
            "SHORTCUT"
        ],
        "folder_tokens": [
            "fld_123456"
        ],
        "only_title": false,
        "open_time": {
            "start": 1742348544,
            "end": 1742348544
        },
        "sort_type": "CREATE_TIME",
        "create_time": {
            "start": 1742348544,
            "end": 1742348544
        }
    },
    "wiki_filter": {
        "creator_ids": [
            "ou_7890123456abcdef"
        ],
        "doc_types": [
            "SHORTCUT"
        ],
        "space_ids": [
            "space_1234567890fedcba"
        ],
        "only_title": false,
        "open_time": {
            "start": 1742348544,
            "end": 1742348544
        },
        "sort_type": "CREATE_TIME",
        "create_time": {
            "start": 1742348544,
            "end": 1742348544
        }
    },
    "page_token": "token_1234567890fedcba",
    "page_size": 15
}
""";
        var result = Deserialize<FeishuNetSdk.Search.PostSearchV2DocWikiSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}