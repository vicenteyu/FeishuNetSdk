// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EnumsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询枚举信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询枚举信息 响应体
/// <para>接口ID：7457854043681603588</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/enum/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fenum%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EnumsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "enums": [
            {
                "enum_apiname": "overtime_date_type",
                "enum_items": [
                    {
                        "api_name": "special_day",
                        "name": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "description": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "enum_api_name": "overtime_date_type",
                        "order": 1,
                        "status": 1
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EnumsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}