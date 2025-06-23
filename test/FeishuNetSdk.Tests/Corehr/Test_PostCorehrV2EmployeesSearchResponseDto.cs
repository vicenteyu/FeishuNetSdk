namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索员工信息 响应体
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesSearchResponseDto : TestBase
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
                "employment_id": "6893014062142064135",
                "employment_id_v2": "6893014062142064135",
                "ats_application_id": "6838119494196871234",
                "prehire_id": "7023239238976141133",
                "employee_number": "1000000",
                "employee_type_id": "6971090097697521314",
                "employee_subtype_id": "6971090097697521317",
                "department_id": "6893014062142064135",
                "department_id_v2": "6893014062142064135",
                "job_level_id": "6893014062142064135",
                "job_level": {
                    "id": "4692446793125560154",
                    "level_order": 9999,
                    "code": "VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=",
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
                    "active": true,
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
                "pathway_id": "6893014062142064135",
                "pathway": {
                    "id": "4692446793125560154",
                    "code": "VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=",
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
                    "active": true,
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
                "job_grade_id": "6893014062142064135",
                "work_location_id": "6893014062142064135",
                "job_family_id": "6893014062142064135",
                "job_family": {
                    "id": "4698019107896524633",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "active": true,
                    "parent_id": "4698020757495316313",
                    "effective_time": "2020-05-01 00:00:00",
                    "expiration_time": "2020-05-02 00:00:00",
                    "code": "123456",
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
                "position_id": "6893014062142064135",
                "position": {
                    "position_id": "4692446793125560154",
                    "code": "A01234",
                    "names": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "descriptions": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "active": true
                },
                "job_id": "6893014062142064135",
                "job": {
                    "id": "4698040628992333549",
                    "code": "JP422119",
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
                    "active": true,
                    "job_title": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ],
                    "pathway_id": "4719519211875096301",
                    "job_family_id_list": [
                        "4719519211875096301"
                    ],
                    "job_level_id_list": [
                        "4719519212005299950"
                    ],
                    "working_hours_type_id": "6890452208593372679",
                    "effective_time": "2020-01-01 00:00:00",
                    "expiration_time": "2021-01-01 00:00:00",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "Sandy"
                        }
                    ]
                },
                "company_id": "6893014062142064135",
                "working_hours_type_id": "6893014062142064135",
                "tenure": "0.01",
                "seniority_date": "2021-03-16",
                "effective_date": "2021-03-16",
                "primary_employment": true,
                "probation_period": 16,
                "on_probation": true,
                "probation_end_date": "2022-08-01",
                "direct_manager_id": "7027024823985411287",
                "dotted_line_manager_id": "7027024823985411782",
                "direct_manager_id_v2": "7027024823985411287",
                "dotted_line_manager_id_v2": "7027024823985411782",
                "employment_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "employment_status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "expiration_date": "2022-08-16",
                "reason_for_offboarding": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "email_address": "test@163.com",
                "work_email_list": [
                    {
                        "email": "1234567@example.feishu.cn",
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
                "cost_center_list": [
                    {
                        "cost_center_id": "6950635856373745165",
                        "rate": 100,
                        "new_rate": 50.2
                    }
                ],
                "rehire": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "rehire_employment_id": "7164286667866966659",
                "person_info": {
                    "person_id": "6919733936050406926",
                    "phone_number": "13649211111",
                    "legal_name": "张三",
                    "preferred_name": "刘梓新(Henry)",
                    "additional_name": "梓新",
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
                            ],
                            "city_subdivision_1": "123",
                            "city_subdivision_2": "123",
                            "region_subdivision_1": "123",
                            "region_subdivision_2": "123"
                        }
                    ],
                    "email_list": [
                        {
                            "email": "1234567@example.feishu.cn",
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
                            "bank_id_v2": "MDBH00000001",
                            "branch_id_v2": "MDBK00000017",
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
                                "enum_name": "blance",
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
                            "IBAN": "CH56 0483 5012 3456 7800 9",
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
                            "address": {
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
                    "first_entry_time": "2021-01-02",
                    "leave_time": "2022-01-02",
                    "religion": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "working_years_v2": 2.1
                },
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
                "noncompete_status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "past_offboarding": true,
                "regular_employee_start_date": "2020-01-01",
                "external_id": "10000000",
                "times_employed": 16,
                "recruitment_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "avatar_url": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_a550d36b-28ef-48ad-9e50-58004beb386j~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp",
                "primary_contract_id": "7164286667866966659",
                "contract_start_date": "2020-01-01",
                "contract_end_date": "2020-01-01",
                "contract_expected_end_date": "2020-01-01",
                "pay_group_id": "7164286667866966659",
                "assignment_pay_group_id": "7164286667866966659",
                "international_assignment": true,
                "work_calendar_id": "7164286667866966659",
                "department": {
                    "id": "4719456877659520852",
                    "id_v2": "4719456877659520852",
                    "department_name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "direct_manager": {
                    "employment_id": "6893014062142064135",
                    "employment_id_v2": "6893014062142064135",
                    "employee_number": "1000000",
                    "email_address": "test@163.com",
                    "person_info": {
                        "person_id": "6919733936050406926",
                        "preferred_name": "刘梓新",
                        "preferred_local_full_name": "刘梓新",
                        "preferred_english_full_name": "Henry"
                    }
                },
                "dotted_line_manager": {
                    "employment_id": "6893014062142064135",
                    "employment_id_v2": "6893014062142064135",
                    "employee_number": "1000000",
                    "email_address": "test@163.com",
                    "person_info": {
                        "person_id": "6919733936050406926",
                        "preferred_name": "刘梓新",
                        "preferred_local_full_name": "刘梓新",
                        "preferred_english_full_name": "Henry"
                    }
                },
                "time_zone": "Asia/Shanghai",
                "service_company": "7174374910734141112",
                "compensation_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "work_shift": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "custom_org": "{\"custom_org_02\":[{\"id\":\"1\",\"rate\":\"99\"}]}",
                "seniority_adjust_information_list": [
                    {
                        "seniority_adjustment_type": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "start_date": "2024-01-01",
                        "end_date": "2024-10-01",
                        "seniority_adjustment": 1.01,
                        "reasons_for_seniority_adjustment": "工厂停产需要减去半年工龄",
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
                "employment_direct_bps": {
                    "hrbp_ids": [
                        "6863326262618752123"
                    ],
                    "location_bp_ids": [
                        "6863326262618752123"
                    ]
                },
                "employment_all_bps": {
                    "hrbp_ids": [
                        "6863326262618752123"
                    ],
                    "location_bp_ids": [
                        "6863326262618752123"
                    ]
                },
                "contract_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "archive_cpst_plan_id": "123456789"
            }
        ],
        "page_token": "eyJldV9uYyI6IlswLFwiNjk2MTI4Njg0NjA5Mzc4ODY4MC03MjExMDM0ODcxMjA3OTUzOTc1XCJdIn0",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EmployeesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}