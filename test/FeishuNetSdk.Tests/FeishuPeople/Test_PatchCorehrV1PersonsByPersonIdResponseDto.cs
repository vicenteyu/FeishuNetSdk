namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新个人信息 响应体
/// <para>接口ID：7021733135817670660</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1PersonsByPersonIdResponseDto : TestBase
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
            "phone_number": "11111111111",
            "legal_name": "张三",
            "preferred_name": "张四",
            "id": "646465654545",
            "name_list": [
                {
                    "local_primary": "黄",
                    "local_first_name": "四",
                    "country_region_id": "6862995757234914824",
                    "name_type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "local_first_name_2": "五",
                    "local_primary_2": "王",
                    "additional_name_type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "first_name": "帅",
                    "full_name": "刘梓新",
                    "hereditary": "王",
                    "middle_name": "大",
                    "name_primary": "王",
                    "secondary": "王",
                    "social": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "tertiary": "王",
                    "title": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "local_middle_name": "大",
                    "local_secondary": "王",
                    "display_name_local_and_western_script": "刘梓新",
                    "display_name_local_script": "刘梓新",
                    "display_name_western_script": "刘梓新",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "gender": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "date_of_birth": "2020-01-01",
            "nationality_id": "123456789",
            "race": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "marital_status": {
                "enum_name": "type_1",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ]
            },
            "phone_list": [
                {
                    "international_area_code": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "phone_number": "010-12345678",
                    "formatted_phone_number": "+86 010-12345678",
                    "device_type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "phone_usage": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
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
            "address_list": [
                {
                    "full_address_local_script": "中国北京北京",
                    "full_address_western_script": "Beijing, Beijing, China,",
                    "id": "6989822217869624863",
                    "country_region_id": "6862995757234914824",
                    "region_id": "6863326815667095047",
                    "city_id": "6863333254578046471",
                    "distinct_id": "6863333516579440141",
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
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "email_list": [
                {
                    "email": "12456@test.com",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "work_experience_list": [
                {
                    "company_organization": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "department": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "job": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "description": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "start_date": "2020-01-01",
                    "end_date": "2020-01-01",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "education_list": [
                {
                    "school": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "level_of_education": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "start_date": "2011-09-01",
                    "end_date": "2015-06-30",
                    "field_of_study": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ],
                    "degree": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "school_name": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "field_of_study_name": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "country_region_id": "1",
                    "expected_end_date": "2011-09-01",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ]
                }
            ],
            "bank_account_list": [
                {
                    "bank_name": "中国农业银行",
                    "bank_account_number": "6231200000001223",
                    "account_holder": "孟十五",
                    "bank": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "branch_name": "中国农业银行支行",
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ],
                    "country_region_id": "12",
                    "bank_account_usage": [
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
                    "bank_account_type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "currency_id": "12QueryCountryRegionSubdivisionDataReq"
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
                            "field_name": "name",
                            "value": "\"Sandy\""
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
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "local_first_name_2": "五",
                        "local_primary_2": "王",
                        "additional_name_type": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "first_name": "帅",
                        "full_name": "刘梓新",
                        "hereditary": "王",
                        "custom_name": "刘梓新",
                        "custom_local_name": "刘梓新",
                        "middle_name": "大",
                        "name_primary": "王",
                        "secondary": "王",
                        "social": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "tertiary": "王",
                        "title": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "local_middle_name": "大",
                        "local_secondary": "王",
                        "display_name_local_and_western_script": "刘梓新",
                        "display_name_local_script": "刘梓新",
                        "display_name_western_script": "刘梓新",
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "\"Sandy\""
                            }
                        ]
                    },
                    "relationship": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "gender": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "date_of_birth": "2020-01-01",
                    "nationality_id": "7075702734054164011",
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
                                    "field_name": "name",
                                    "value": "\"Sandy\""
                                }
                            ]
                        }
                    ],
                    "spouses_working_status": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "is_this_person_covered_by_health_insurance": true,
                    "is_this_person_allowed_for_tax_deduction": false,
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ],
                    "dependent_name": "张三",
                    "employer": "海淀区交警大队",
                    "job": "保安",
                    "phone": {
                        "international_area_code": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "phone_number": "010-12345678",
                        "formatted_phone_number": "+86 010-12345678",
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "\"Sandy\""
                            }
                        ]
                    },
                    "address": {
                        "full_address_local_script": "中国北京北京",
                        "full_address_western_script": "Beijing, Beijing, China,",
                        "id": "6989822217869624863",
                        "country_region_id": "6862995757234914824",
                        "region_id": "6863326815667095047",
                        "city_id": "6863333254578046471",
                        "distinct_id": "6863333516579440141",
                        "local_address_line1": "丹佛测试地址-纽埃时区",
                        "local_address_line2": "PoewH",
                        "local_address_line3": "丹佛测试地址-纽埃时区",
                        "local_address_line4": "PoewH",
                        "local_address_line5": "PoewH",
                        "local_address_line6": "jmwJc",
                        "local_address_line7": "jmwJc",
                        "local_address_line8": "jmwJc",
                        "local_address_line9": "jmwJc",
                        "postal_code": "rafSu",
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "Sandy"
                            }
                        ]
                    },
                    "birth_certificate_of_child": [
                        {
                            "id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200"
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
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "local_first_name_2": "五",
                        "local_primary_2": "王",
                        "additional_name_type": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "first_name": "帅",
                        "full_name": "刘梓新",
                        "hereditary": "王",
                        "custom_name": "刘梓新",
                        "custom_local_name": "刘梓新",
                        "middle_name": "大",
                        "name_primary": "王",
                        "secondary": "王",
                        "social": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "tertiary": "王",
                        "title": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "local_middle_name": "大",
                        "local_secondary": "王",
                        "display_name_local_and_western_script": "刘梓新",
                        "display_name_local_script": "刘梓新",
                        "display_name_western_script": "刘梓新",
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "\"Sandy\""
                            }
                        ]
                    },
                    "relationship": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "phone_ist": [
                        {
                            "international_area_code": {
                                "enum_name": "type_1",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "张三"
                                    }
                                ]
                            },
                            "phone_number": "010-12345678",
                            "formatted_phone_number": "+86 010-12345678",
                            "custom_fields": [
                                {
                                    "field_name": "name",
                                    "value": "\"Sandy\""
                                }
                            ]
                        }
                    ],
                    "custom_fields": [
                        {
                            "field_name": "name",
                            "value": "\"Sandy\""
                        }
                    ],
                    "legal_name": "张三"
                }
            ],
            "date_entered_workforce": "2020-10-01",
            "profile_image_id": "dfysuc8x76dsfsw",
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ],
            "email_address": "test@163.com",
            "resident_tax_id_list": [
                "123456"
            ],
            "age": 25,
            "highest_level_of_education": {
                "school": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "level_of_education": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "start_date": "2011-09-01",
                "end_date": "2015-06-30",
                "field_of_study": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "degree": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "school_name": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "field_of_study_name": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "country_region_id": "1",
                "expected_end_date": "2011-09-01",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            },
            "highest_degree_of_education": {
                "school": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "level_of_education": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "start_date": "2011-09-01",
                "end_date": "2015-06-30",
                "field_of_study": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "degree": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "school_name": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "field_of_study_name": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "country_region_id": "1",
                "expected_end_date": "2011-09-01",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            },
            "personal_profile": [
                {
                    "personal_profile_id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200",
                    "personal_profile_type": {
                        "enum_name": "type_1",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ]
                    },
                    "files": [
                        {
                            "id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200"
                        }
                    ]
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PatchCorehrV1PersonsByPersonIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}