// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSearchV2DataSourcesByDataSourceIdItemsByItemIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定数据项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 查询指定数据项 响应体
/// <para>接口ID：6953505452630228995</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source-item/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source-item%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSearchV2DataSourcesByDataSourceIdItemsByItemIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "item": {
            "id": "01010111",
            "acl": [
                {
                    "access": "allow",
                    "value": "d35e3c23",
                    "type": "user"
                }
            ],
            "metadata": {
                "title": "工单：无法创建文章",
                "source_url": "http://www.abc.com.cn",
                "create_time": 1618831236,
                "update_time": 1618831236
            },
            "structured_data": "{\"key\":\"value\"}",
            "content": {
                "format": "html",
                "content_data": "这是一个很长的文本"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.GetSearchV2DataSourcesByDataSourceIdItemsByItemIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}