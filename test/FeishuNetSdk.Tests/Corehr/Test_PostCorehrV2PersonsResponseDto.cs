// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PersonsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建个人信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建个人信息 响应体
/// <para>接口ID：7225452763517108227</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fperson%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PersonsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "person": {
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
                        "enum_name": "legal_name",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "local_first_name_2": "五",
                    "local_primary_2": "王",
                    "additional_name_type": {
                        "enum_name": "legal_name",
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
                    "social": {
                        "enum_name": "example",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "tertiary": "王",
                    "title": {
                        "enum_name": "example",
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
                "enum_name": "male",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "date_of_birth": "2020-01-01",
            "race": {
                "enum_name": "example",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "marital_status": {
                "enum_name": "example",
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
                        "enum_name": "86_china",
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
                        "enum_name": "mobile_phone",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "phone_usage": {
                        "enum_name": "home",
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
                            "enum_name": "example",
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
                    "email": "1234567@ example.feishu.cn",
                    "is_primary": true,
                    "is_public": true,
                    "email_usage": {
                        "enum_name": "home",
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
                        "enum_name": "phd",
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
                        "enum_name": "mba",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "school_name": {
                        "enum_name": "example",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "field_of_study_name": {
                        "enum_name": "example",
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
                    "bank_id_v2": "MDBH00000001",
                    "branch_id_v2": "MDBK00000017",
                    "country_region_id": "12",
                    "bank_account_usage": [
                        {
                            "enum_name": "checking",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        }
                    ],
                    "bank_account_type": {
                        "enum_name": "checking",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "currency_id": "12QueryCountryRegionSubdivisionDataReq",
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
                    "name": {
                        "local_primary": "黄",
                        "local_first_name": "四",
                        "country_region_id": "6862995757234914824",
                        "name_type": {
                            "enum_name": "legal_name",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "local_first_name_2": "五",
                        "local_primary_2": "王",
                        "additional_name_type": {
                            "enum_name": "legal_name",
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
                        "social": {
                            "enum_name": "example",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "tertiary": "王",
                        "title": {
                            "enum_name": "example",
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
                        "enum_name": "parent",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "gender": {
                        "enum_name": "male",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "date_of_birth": "2020-01-01",
                    "nationality_id_v2": "6862995745046267401",
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
                        "enum_name": "example",
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
                            "enum_name": "86_china",
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
                            "enum_name": "fax",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "phone_usage": {
                            "enum_name": "home",
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
                                "enum_name": "home_address",
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
                    "name": {
                        "local_primary": "黄",
                        "local_first_name": "四",
                        "country_region_id": "6862995757234914824",
                        "name_type": {
                            "enum_name": "legal_name",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "local_first_name_2": "五",
                        "local_primary_2": "王",
                        "additional_name_type": {
                            "enum_name": "emergency_contact_name",
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
                        "social": {
                            "enum_name": "example",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "tertiary": "王",
                        "title": {
                            "enum_name": "example",
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
                        "enum_name": "parent",
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
                                "enum_name": "86_china",
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
                                "enum_name": "fax",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "phone_usage": {
                                "enum_name": "home",
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
                                "enum_name": "86_china",
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
                                "enum_name": "fax",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "phone_usage": {
                                "enum_name": "home",
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
                    ]
                }
            ],
            "date_entered_workforce": "2020-10-01",
            "working_years": 2,
            "profile_image_id": "dfysuc8x76dsfsw",
            "email_address": "test@example.feishu.cn",
            "age": 22,
            "highest_level_of_education": {
                "school": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "level_of_education": {
                    "enum_name": "phd",
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
                    "enum_name": "mba",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "school_name": {
                    "enum_name": "example",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "field_of_study_name": {
                    "enum_name": "example",
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
                    "enum_name": "phd",
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
                    "enum_name": "mba",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "school_name": {
                    "enum_name": "example",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "field_of_study_name": {
                    "enum_name": "example",
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
                        "enum_name": "example",
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
            "native_region": "6863326262618752111",
            "hukou_type": {
                "enum_name": "example",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "hukou_location": "山东省平阴县",
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
                        "enum_name": "example",
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
            "first_entry_time": "2021-01-02",
            "leave_time": "2022-01-02",
            "passport_number": "6919733936050406926"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PersonsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}