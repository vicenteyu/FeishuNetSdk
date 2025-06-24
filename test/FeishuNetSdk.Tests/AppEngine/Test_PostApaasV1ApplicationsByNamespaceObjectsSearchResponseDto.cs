// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1ApplicationsByNamespaceObjectsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 搜索记录 响应体
/// <para>接口ID：7384730094873051164</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "records": "[]",
        "has_more": true,
        "next_page_token": "eyJvYmplY3RzX3BhZ2VfdG9rZW4iOlt7Im9ial9pZCI6MTc2OTI4NzM5M",
        "objects": [
            {
                "object": {
                    "id": 1764024447556775,
                    "api_name": "user",
                    "label": {
                        "zh_cn": "text"
                    },
                    "settings": {
                        "display_name": "_id",
                        "allow_search_fields": [
                            "_id"
                        ],
                        "search_layout": {
                            "display_fields": [
                                "_id"
                            ]
                        }
                    }
                },
                "fields": [
                    {
                        "id": 1764024447525960,
                        "api_name": "user",
                        "type": "string",
                        "label": {
                            "zh_cn": "text"
                        }
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}