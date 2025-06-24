// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAilyV1AppsByAppIdDataAssetsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询数据知识列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 查询数据知识列表 响应体
/// <para>接口ID：7424752773160796164</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppsByAppIdDataAssetsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "data_asset_id": "asset_aadg3mcgvpybu",
                "label": {
                    "zh_cn": "数据知识标题"
                },
                "description": {
                    "zh_cn": "这个是电影相关的知识集合"
                },
                "data_source_type": "excel",
                "connect_status": "successful",
                "tags": [
                    {
                        "data_asset_tag_id": "spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs",
                        "name": "电影"
                    }
                ],
                "items": [
                    {
                        "data_asset_item_id": "asset_item_aadg3mcgvpydu",
                        "api_name": "movie",
                        "label": {
                            "zh_cn": "标题"
                        },
                        "description": {
                            "zh_cn": "描述内容"
                        },
                        "resources": [
                            {
                                "resource_id": "spring_5862e4fea8__c__dataset_aadg3lxm4j6mg",
                                "resource_type": "dataset"
                            }
                        ]
                    }
                ],
                "connect_failed_reason": "连接超时",
                "connect_type": "direct",
                "created_time": "1711975665710",
                "updated_time": "1711975665710"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppsByAppIdDataAssetsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}