// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取数据表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取数据表列表 响应体
/// <para>接口ID：7620858064161934543</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-table/get_table_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-table%2fget_table_list</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdTablesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "items": [
            {
                "name": "student",
                "description": "studect数据表",
                "columns": [
                    {
                        "name": "column_name",
                        "description": "column_name的描述",
                        "data_type": "varchar",
                        "is_primary_key": false,
                        "is_unique": false,
                        "is_auto_increment": false,
                        "is_array": false,
                        "is_allow_null": false,
                        "default_value": "默认值"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdTablesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}