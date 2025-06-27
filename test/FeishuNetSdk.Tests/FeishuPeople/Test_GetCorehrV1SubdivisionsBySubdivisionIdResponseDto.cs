// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1SubdivisionsBySubdivisionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单条省份/行政区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单条省份/行政区信息 响应体
/// <para>接口ID：7072978219502321665</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsubdivision%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1SubdivisionsBySubdivisionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "subdivision": {
            "id": "12",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "张三"
                }
            ],
            "country_region_id": "12",
            "subdivision_type": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1SubdivisionsBySubdivisionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}