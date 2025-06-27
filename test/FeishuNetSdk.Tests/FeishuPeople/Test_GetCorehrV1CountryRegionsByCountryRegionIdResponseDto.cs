// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1CountryRegionsByCountryRegionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单条国家/地区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单条国家/地区信息 响应体
/// <para>接口ID：7072978180814618652</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcountry_region%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CountryRegionsByCountryRegionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "country_region": {
            "id": "1",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "张三"
                }
            ],
            "alpha_3_code": "12",
            "alpha_2_code": "12"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CountryRegionsByCountryRegionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}