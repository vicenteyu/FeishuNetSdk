namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询公司 响应体
/// <para>接口ID：7017707615191105539</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/company/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompany%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CompaniesResponseDto : TestBase
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
                "id": "4692472714243080020",
                "hiberarchy_common": {
                    "parent_id": "4719168654814483759",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
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
                            "value": "张三"
                        }
                    ],
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                },
                "type": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "industry_list": [
                    {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    }
                ],
                "legal_representative": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "post_code": "邮编",
                "tax_payer_id": "123456840",
                "confidential": true,
                "sub_type_list": [
                    {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    }
                ],
                "branch_company": true,
                "primary_manager": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ],
                "currency": {
                    "id": "1",
                    "country_region_id": "12",
                    "currency_name": [
                        {
                            "lang": "zh-CN",
                            "value": "刘梓新"
                        }
                    ],
                    "numeric_code": 12,
                    "currency_alpha_3_code": "12"
                },
                "phone": {
                    "area_code": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "刘梓新"
                            }
                        ]
                    },
                    "phone_number": "213213"
                },
                "fax": {
                    "area_code": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "刘梓新"
                            }
                        ]
                    },
                    "phone_number": "213213"
                },
                "registered_office_address": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ],
                "office_address": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ],
                "registered_office_address_info": {
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
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "刘梓新"
                                }
                            ]
                        }
                    ],
                    "is_primary": true,
                    "is_public": true
                },
                "office_address_info": {
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
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "刘梓新"
                                }
                            ]
                        }
                    ],
                    "is_primary": true,
                    "is_public": true
                }
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CompaniesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}