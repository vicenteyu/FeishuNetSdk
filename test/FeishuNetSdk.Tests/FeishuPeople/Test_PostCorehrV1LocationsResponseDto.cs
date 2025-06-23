namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建地点 响应体
/// <para>接口ID：7072646479949316098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/location/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2flocation%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LocationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "location": {
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
                            "value": "地点"
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
                    "enum_name": "phone_type",
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1LocationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}