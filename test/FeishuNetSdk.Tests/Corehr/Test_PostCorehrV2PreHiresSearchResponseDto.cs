// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索待入职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索待入职信息 响应体
/// <para>接口ID：7263303427627270148</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresSearchResponseDto : TestBase
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
                "person_info": {
                    "person_id": "6919733936050406926",
                    "phone_number": "13649211111",
                    "legal_name": "张三",
                    "preferred_name": "刘梓新(Henry)",
                    "preferred_local_full_name": "刘梓新",
                    "preferred_english_full_name": "Henry",
                    "name_list": [
                        {
                            "local_primary": "黄",
                            "local_first_name": "四",
                            "country_region_id": "6862995757234914824",
                            "name_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "local_first_name_2": "五",
                            "local_primary_2": "王",
                            "additional_name": "别名",
                            "additional_name_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "first_name": "帅",
                            "full_name": "王大帅",
                            "hereditary": "王",
                            "custom_name": "王大帅",
                            "custom_local_name": "王大帅",
                            "middle_name": "大",
                            "name_primary": "王",
                            "secondary": "王",
                            "tertiary": "王",
                            "social": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "title": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "local_middle_name": "大",
                            "local_secondary": "王",
                            "display_name_local_and_western_script": "王大帅",
                            "display_name_local_script": "王大帅",
                            "display_name_western_script": "王大帅"
                        }
                    ],
                    "gender": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "date_of_birth": "2020-01-01",
                    "nationality_id_v2": "6862995757234914821",
                    "race": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "marital_status": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "phone_list": [
                        {
                            "international_area_code": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "phone_number": "010-12345678",
                            "formatted_phone_number": "+86 010-12345678",
                            "device_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "phone_usage": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "is_primary": true,
                            "is_public": true
                        }
                    ],
                    "address_list": [
                        {
                            "full_address_local_script": "中国北京北京",
                            "full_address_western_script": "Beijing, Beijing, China,",
                            "address_id": "6989822217869624863",
                            "country_region_id": "6862995757234914824",
                            "region_id": "6863326815667095047",
                            "city_id": "6863333254578046471",
                            "distinct_id": "6863333516579440141",
                            "city_id_v2": "6863333254578046471",
                            "district_id_v2": "6863333516579440141",
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
                                            "value": "中文示例"
                                        }
                                    ]
                                }
                            ],
                            "is_primary": true,
                            "is_public": true,
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "email_list": [
                        {
                            "email": "1234567@bytedance.com",
                            "is_primary": true,
                            "is_public": true,
                            "email_usage": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            }
                        }
                    ],
                    "work_experience_list": [
                        {
                            "company_organization": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "department": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "job": [
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
                            "start_date": "2020-01-01",
                            "end_date": "2020-01-01",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "education_list": [
                        {
                            "school": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "level_of_education": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "start_date": "2011-09-01",
                            "end_date": "2015-06-30",
                            "field_of_study": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "degree": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "school_name": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "field_of_study_name": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "country_region_id": "1",
                            "expected_end_date": "2011-09-01",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "bank_account_list": [
                        {
                            "bank_name": "中国农业银行",
                            "bank_account_number": "6231200000001223",
                            "account_holder": "孟十五",
                            "branch_name": "中国农业银行支行",
                            "country_region_id": "12",
                            "bank_account_usage": [
                                {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                }
                            ],
                            "bank_account_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "payment_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "payment_rate": "70.21",
                            "payment_amount": "5000",
                            "priority": 1,
                            "currency_id": "12",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "national_id_list": [
                        {
                            "national_id_type_id": "6863330041896371725",
                            "national_id_number": "1231131333",
                            "issue_date": "2020-04-01",
                            "expiration_date": "2020-05-21",
                            "country_region_id": "6862995757234914824",
                            "issued_by": "北京市公安局",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "dependent_list": [
                        {
                            "id": "123",
                            "name": {
                                "local_primary": "黄",
                                "local_first_name": "四",
                                "country_region_id": "6862995757234914824",
                                "name_type": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "local_first_name_2": "五",
                                "local_primary_2": "王",
                                "additional_name": "别名",
                                "additional_name_type": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "first_name": "帅",
                                "full_name": "王大帅",
                                "hereditary": "王",
                                "custom_name": "王大帅",
                                "custom_local_name": "王大帅",
                                "middle_name": "大",
                                "name_primary": "王",
                                "secondary": "王",
                                "tertiary": "王",
                                "social": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "title": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "local_middle_name": "大",
                                "local_secondary": "王",
                                "display_name_local_and_western_script": "王大帅",
                                "display_name_local_script": "王大帅",
                                "display_name_western_script": "王大帅"
                            },
                            "relationship": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "gender": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "date_of_birth": "2020-01-01",
                            "national_id_list": [
                                {
                                    "national_id_type_id": "6863330041896371725",
                                    "national_id_number": "1231131333",
                                    "issue_date": "2020-04-01",
                                    "expiration_date": "2020-05-21",
                                    "country_region_id": "6862995757234914824",
                                    "issued_by": "北京市公安局",
                                    "custom_fields": [
                                        {
                                            "custom_api_name": "name",
                                            "name": {
                                                "zh_cn": "自定义姓名",
                                                "en_us": "Custom Name"
                                            },
                                            "type": 1,
                                            "value": "\"231\""
                                        }
                                    ]
                                }
                            ],
                            "spouses_working_status": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "is_this_person_covered_by_health_insurance": true,
                            "is_this_person_allowed_for_tax_deduction": false,
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ],
                            "dependent_name": "张三",
                            "employer": "海淀区交警大队",
                            "job": "保安",
                            "phone": {
                                "international_area_code": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "phone_number": "010-12345678",
                                "formatted_phone_number": "+86 010-12345678",
                                "device_type": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "phone_usage": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "is_primary": true,
                                "is_public": true
                            },
                            "address": {
                                "full_address_local_script": "中国北京北京",
                                "full_address_western_script": "Beijing, Beijing, China,",
                                "address_id": "6989822217869624863",
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
                                                "value": "中文示例"
                                            }
                                        ]
                                    }
                                ],
                                "is_primary": true,
                                "is_public": true,
                                "custom_fields": [
                                    {
                                        "custom_api_name": "name",
                                        "name": {
                                            "zh_cn": "自定义姓名",
                                            "en_us": "Custom Name"
                                        },
                                        "type": 1,
                                        "value": "\"231\""
                                    }
                                ]
                            },
                            "birth_certificate_of_child": [
                                {
                                    "id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200",
                                    "name": "document.txt"
                                }
                            ]
                        }
                    ],
                    "emergency_contact_list": [
                        {
                            "id": "123",
                            "name": {
                                "local_primary": "黄",
                                "local_first_name": "四",
                                "country_region_id": "6862995757234914824",
                                "name_type": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "local_first_name_2": "五",
                                "local_primary_2": "王",
                                "additional_name": "别名",
                                "additional_name_type": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "first_name": "帅",
                                "full_name": "王大帅",
                                "hereditary": "王",
                                "custom_name": "王大帅",
                                "custom_local_name": "王大帅",
                                "middle_name": "大",
                                "name_primary": "王",
                                "secondary": "王",
                                "tertiary": "王",
                                "social": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "title": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "local_middle_name": "大",
                                "local_secondary": "王",
                                "display_name_local_and_western_script": "王大帅",
                                "display_name_local_script": "王大帅",
                                "display_name_western_script": "王大帅"
                            },
                            "relationship": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "phone_ist": [
                                {
                                    "international_area_code": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "phone_number": "010-12345678",
                                    "formatted_phone_number": "+86 010-12345678",
                                    "device_type": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "phone_usage": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "is_primary": true,
                                    "is_public": true
                                }
                            ],
                            "phone_list": [
                                {
                                    "international_area_code": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "phone_number": "010-12345678",
                                    "formatted_phone_number": "+86 010-12345678",
                                    "device_type": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "phone_usage": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    },
                                    "is_primary": true,
                                    "is_public": true
                                }
                            ],
                            "legal_name": "张三",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ],
                            "is_primary": true
                        }
                    ],
                    "date_entered_workforce": "2020-10-01",
                    "working_years": 2,
                    "profile_image_id": "dfysuc8x76dsfsw",
                    "email_address": "test@163.com",
                    "age": 22,
                    "highest_level_of_education": {
                        "school": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "level_of_education": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "start_date": "2011-09-01",
                        "end_date": "2015-06-30",
                        "field_of_study": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "degree": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "school_name": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "field_of_study_name": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "country_region_id": "1",
                        "expected_end_date": "2011-09-01",
                        "custom_fields": [
                            {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            }
                        ]
                    },
                    "highest_degree_of_education": {
                        "school": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "level_of_education": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "start_date": "2011-09-01",
                        "end_date": "2015-06-30",
                        "field_of_study": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "degree": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "school_name": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "field_of_study_name": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "country_region_id": "1",
                        "expected_end_date": "2011-09-01",
                        "custom_fields": [
                            {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            }
                        ]
                    },
                    "personal_profile": [
                        {
                            "personal_profile_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "files": [
                                {
                                    "id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200",
                                    "name": "document.txt"
                                }
                            ]
                        }
                    ],
                    "talent_id": "6863326262618752123",
                    "custom_fields": [
                        {
                            "custom_api_name": "name",
                            "name": {
                                "zh_cn": "自定义姓名",
                                "en_us": "Custom Name"
                            },
                            "type": 1,
                            "value": "\"231\""
                        }
                    ],
                    "national_id_number": "11010000000000",
                    "family_address": "6863326262618752123",
                    "person_info_chns": [
                        {
                            "native_region": "6863326262618752111",
                            "hukou_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "hukou_location": "山东省平阴县",
                            "political_affiliations": [
                                {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                }
                            ]
                        }
                    ],
                    "born_country_region": "中国",
                    "is_disabled": true,
                    "disable_card_number": "1110000",
                    "is_martyr_family": true,
                    "martyr_card_number": "1110000",
                    "is_old_alone": true,
                    "resident_taxes": [
                        {
                            "year_resident_tax": "2023",
                            "resident_status": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "tax_country_region_id": "中国",
                            "custom_fields": [
                                {
                                    "field_name": "name",
                                    "value": "Sandy"
                                }
                            ]
                        }
                    ],
                    "religion": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "working_years_v2": 2.1,
                    "created_at": "2023-09-01 13:21:12",
                    "updated_at": "2023-09-01 13:21:12",
                    "created_by": "69928404442626824",
                    "updated_by": "69928404442626824",
                    "bank_account_number": "69928404442626824",
                    "passport_number": "6919733936050406926",
                    "former_employer": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "employment_info": {
                    "department_id": "7147562782945478177",
                    "cost_center_rates": [
                        {
                            "cost_center_id": "6950635856373745165",
                            "rate": 100,
                            "new_rate": 50.2
                        }
                    ],
                    "office_location_id": "6977976687350924832",
                    "work_location_id": "6977976687350924832",
                    "work_station": "ABC123",
                    "worker_id": "1234567",
                    "compensation_type": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "direct_leader_id": "7032210902531327521",
                    "dotted_line_manager_id": "7032210902531327521",
                    "job_id": "6977976735715378724",
                    "job_family_id": "6977972856625939999",
                    "job_level_id": "6977971894960145950",
                    "job_grade_id": "6977971894960145950",
                    "job_title": "java",
                    "employee_type_id": "6977973225846343171",
                    "employee_subtype_id": "6977973225846343171",
                    "employment_type": "employee",
                    "work_email": "joshua@bytedance.com",
                    "company_id": "6738317738688661772",
                    "social_security_city_id": "6977973225846343171",
                    "non_compete_covenant": true,
                    "weekly_working_hours": 8,
                    "rehire": "no",
                    "rehire_employment_id": "6977973225846343172",
                    "working_hours_type": "6977973225846343171",
                    "weekly_working_hours_v2": 8.5,
                    "office_address": {
                        "full_address_local_script": "中国北京北京",
                        "full_address_western_script": "Beijing, Beijing, China,",
                        "address_id": "6989822217869624863",
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
                                        "value": "中文示例"
                                    }
                                ]
                            }
                        ],
                        "is_primary": true,
                        "is_public": true,
                        "custom_fields": [
                            {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            }
                        ]
                    },
                    "working_calendar_id": "6977973225846343173",
                    "updated_at": "2023-01-10 10:29",
                    "suspected_rehiring": false,
                    "condition_worker": false,
                    "custom_fields": [
                        {
                            "custom_api_name": "name",
                            "name": {
                                "zh_cn": "自定义姓名",
                                "en_us": "Custom Name"
                            },
                            "type": 1,
                            "value": "\"231\""
                        }
                    ],
                    "position_id": "6977976735715373452",
                    "company_manual_updated": true,
                    "pay_group": {
                        "name": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ],
                        "id": "1234566"
                    },
                    "whether_the_information_is_abnormal": true,
                    "abnormal_reason": [
                        {
                            "descriptions": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        }
                    ],
                    "has_offer_salary": true,
                    "recruitment_project_id": "23214213152",
                    "work_shift": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "created_at": "2023-09-01 13:21:12",
                    "created_by": "69928404442626824",
                    "updated_by": "69928404442626824",
                    "seniority_date": "2023-01-10",
                    "background_check_order_id": "123",
                    "background_check_order_name": "xxx",
                    "background_check_order_package_name": "xxx",
                    "background_check_order_result": "通过",
                    "background_check_order_supplier_name": "xxx",
                    "background_check_order_account_name": "xxx",
                    "background_check_order_start_time": "2023-01-10 10:29",
                    "background_check_order_complete_time": "2023-01-10 10:29",
                    "background_check_order_status": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "seniority_adjust_information_list": [
                        {
                            "seniority_adjustment": 0.5,
                            "seniority_adjustment_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "reasons_for_seniority_adjustment": "工厂停产需要减去半年工龄",
                            "start_date": "2024-05-19",
                            "end_date": "2024-11-18",
                            "custom_fields": [
                                {
                                    "custom_api_name": "name",
                                    "name": {
                                        "zh_cn": "自定义姓名",
                                        "en_us": "Custom Name"
                                    },
                                    "type": 1,
                                    "value": "\"231\""
                                }
                            ]
                        }
                    ],
                    "notice_period_positive_voluntary": {
                        "wk_id": "4698019107896524633",
                        "value": 1,
                        "value_unit": "月",
                        "name": {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    },
                    "notice_period_probation_involuntary": {
                        "wk_id": "4698019107896524633",
                        "value": 1,
                        "value_unit": "月",
                        "name": {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    },
                    "notice_period_positive_involuntary": {
                        "wk_id": "4698019107896524633",
                        "value": 1,
                        "value_unit": "月",
                        "name": {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    },
                    "notice_period_probation_voluntary": {
                        "wk_id": "4698019107896524633",
                        "value": 1,
                        "value_unit": "月",
                        "name": {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    },
                    "working_hours_type_manual_updated": true,
                    "is_over_due": true,
                    "task_completed": true,
                    "expected_graduate_date": "2023-01-10",
                    "service_company": "6738317738688661772",
                    "pathway": "7460865381179115052",
                    "default_cost_center": {
                        "cost_center_id": "6950635856373745165",
                        "effective_time": "2025-01-01",
                        "is_herit": false,
                        "inherit_source": "department"
                    },
                    "cost_allocation": {
                        "effective_time": "2025-01-01",
                        "expiration_time": "2025-02-01",
                        "cost_center_rates": [
                            {
                                "cost_center_id": "6950635856373745165",
                                "rate": 100,
                                "new_rate": 50.2
                            }
                        ]
                    },
                    "reuse_feishu_account": "reuse",
                    "reused_feishu_account_id": "6738317738688661772"
                },
                "onboarding_info": {
                    "offer_id": "7032210902531327521",
                    "offer_hr_id": "7032210902531327521",
                    "offer_hr_id_v2": "7032210902531327521",
                    "entry_mode": "onsite",
                    "onboarding_date": "2022-10-08",
                    "ats_application_id": "7140946969586010376",
                    "recruitment_type": "recent_graduates",
                    "onboarding_location_id": "6977976687350924832",
                    "company_sponsored_visa": true,
                    "onboarding_status": "preboarding",
                    "onboarding_task_list": [
                        {
                            "task_name": "task_1",
                            "task_status": "abc",
                            "operator_id": "7032210902531327521",
                            "task_code": "task_11"
                        }
                    ],
                    "onboarding_address": {
                        "full_address_local_script": "中国北京北京",
                        "full_address_western_script": "Beijing, Beijing, China,",
                        "address_id": "6989822217869624863",
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
                                        "value": "中文示例"
                                    }
                                ]
                            }
                        ],
                        "is_primary": true,
                        "is_public": true,
                        "custom_fields": [
                            {
                                "custom_api_name": "name",
                                "name": {
                                    "zh_cn": "自定义姓名",
                                    "en_us": "Custom Name"
                                },
                                "type": 1,
                                "value": "\"231\""
                            }
                        ]
                    },
                    "flow_name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "flow_id": "2342352325",
                    "check_in_time": "2023-09-01 13:21:12",
                    "check_in_method": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    }
                },
                "probation_info": {
                    "probation_start_date": "2022-07-29",
                    "probation_end_date": "2023-04-07",
                    "probation_period": 6
                },
                "contract_info": {
                    "contract_start_date": "2022-10-08",
                    "contract_end_date": "2025-10-07",
                    "contract_type": "labor_contract",
                    "duration_type": "fixed_term",
                    "signing_type": "renewed",
                    "contract_file_ids": [
                        "6890452208593372141"
                    ]
                },
                "pre_hire_id": "7032210902531327521"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PreHiresSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}