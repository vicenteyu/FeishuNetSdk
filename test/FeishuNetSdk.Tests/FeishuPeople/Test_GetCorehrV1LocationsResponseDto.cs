// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1LocationsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量分页查询地点信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量分页查询地点信息 响应体
/// <para>接口ID：7017707615190990851</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1LocationsResponseDto : TestBase
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
                "id": "4718803945687580505",
                "hiberarchy_common": {
                    "parent_id": "4719168654814483759",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "刘梓新"
                        }
                    ],
                    "type": {
                        "enum_name": "location",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": " 地点"
                            }
                        ]
                    },
                    "active": true,
                    "effective_time": "2020-05-01 00:00:00",
                    "expiration_time": "2020-05-02 00:00:00",
                    "code": "12456",
                    "description": [
                        {
                            "lang": "zh-CN",
                            "value": "刘梓新"
                        }
                    ],
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                },
                "location_usage_list": [
                    {
                        "enum_name": "work_location",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "工作地点"
                            }
                        ]
                    }
                ],
                "address": [
                    {
                        "full_address_local_script": "中国北京北京",
                        "full_address_western_script": "Beijing, Beijing, China,",
                        "id": "6989822217869624863",
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
                        "local_address_line2": "New York",
                        "local_address_line3": "New York",
                        "local_address_line4": "New York",
                        "local_address_line5": "New York",
                        "local_address_line6": "New York",
                        "local_address_line7": "New York",
                        "local_address_line8": "New York",
                        "local_address_line9": "New York",
                        "postal_code": "611530",
                        "address_type_list": [
                            {
                                "enum_name": "onboarding_address",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": " 入职地址"
                                    }
                                ]
                            }
                        ],
                        "is_primary": true,
                        "is_public": true,
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "\"Sandy\""
                            }
                        ]
                    }
                ],
                "working_hours_type_id": "4690238309151997779",
                "effective_time": "2020-05-01 00:00:00",
                "expiration_time": "2020-05-02 00:00:00",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ],
                "locale": {
                    "enum_name": "zh_cn",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "刘梓新"
                        }
                    ]
                },
                "time_zone_id": "123456789",
                "display_language_id": "123456789"
            }
        ],
        "has_more": true,
        "page_token": "7094095584361137709"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1LocationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}