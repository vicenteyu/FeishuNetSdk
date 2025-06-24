// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询省份/主要行政区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询省份/主要行政区信息 响应体
/// <para>接口ID：7301516605753245699</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region_subdivision%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchResponseDto : TestBase
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
                "country_region_subdivision_id": "6863326571462133262",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "country_region_id": "6862995791674344967",
                "subdivision_type": {
                    "enum_name": "governorate",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "iso_code": "PSE-GZA",
                "status": 1
            }
        ],
        "page_token": "6891251722631890445",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}