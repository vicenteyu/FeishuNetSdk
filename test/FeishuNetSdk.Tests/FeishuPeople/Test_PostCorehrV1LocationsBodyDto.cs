// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1LocationsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建地点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建地点 请求体
/// <para>接口ID：7072646479949316098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LocationsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "hiberarchy_common": {
        "parent_id": "4719168654814483759",
        "name": [
            {
                "lang": "zh-CN",
                "value": "刘梓新"
            }
        ],
        "active": true,
        "code": "12456",
        "description": [
            {
                "lang": "zh-CN",
                "value": "刘梓新"
            }
        ]
    },
    "location_usage_list": [
        {
            "enum_name": "work_space"
        }
    ],
    "address": [
        {
            "country_region_id": "6862995757234914824",
            "region_id": "6863326815667095047",
            "city_id": "6863333254578046471",
            "distinct_id": "6863333516579440141",
            "address_line1": "丹佛测试地址-纽埃时区",
            "address_line2": "PoewH",
            "address_line3": "PoewH",
            "address_line4": "jmwJc",
            "address_line5": "jmwJc",
            "address_line6": "jmwJc",
            "address_line7": "jmwJc",
            "address_line8": "rafSu",
            "address_line9": "McPRG",
            "local_address_line1": "丹佛测试地址-纽埃时区",
            "local_address_line2": "PoewH",
            "local_address_line3": "PoewH",
            "local_address_line4": "jmwJc",
            "local_address_line5": "jmwJc",
            "local_address_line6": "jmwJc",
            "local_address_line7": "jmwJc",
            "local_address_line8": "rafSu",
            "local_address_line9": "McPRG",
            "postal_code": "611530",
            "address_type_list": [
                {
                    "enum_name": "registered_address"
                }
            ],
            "is_primary": true,
            "is_public": true
        }
    ],
    "working_hours_type_id": "4690238309151997779",
    "effective_time": "2020-05-01 00:00:00",
    "locale": {
        "enum_name": "zh_cn"
    },
    "time_zone_id": "123456789",
    "display_language_id": "123456789"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1LocationsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}