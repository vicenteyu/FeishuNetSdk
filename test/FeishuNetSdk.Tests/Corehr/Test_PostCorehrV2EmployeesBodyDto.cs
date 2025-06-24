// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EmployeesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加人员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 添加人员 请求体
/// <para>接口ID：7350663854198161410</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "personal_info": {
        "personal_basic_info": {
            "legal_name": {
                "additional_name_type": "emergency_contact_name",
                "country_region": "6862995757234914824",
                "full_name": "王大帅",
                "hereditary": "王",
                "middle_name": "大",
                "secondary": "王",
                "social": "ii",
                "tertiary": "王",
                "local_first_name_2": "五",
                "local_middle_name": "大",
                "local_primary": "黄",
                "local_primary_2": "王",
                "local_secondary": "王",
                "title": "Mr",
                "local_first_name": "四",
                "custom_local_name": "王大帅",
                "custom_western_name": "王大帅",
                "first_name": "帅",
                "name_primary": "王"
            },
            "preferred_name": {
                "additional_name_type": "emergency_contact_name",
                "country_region": "6862995757234914824",
                "full_name": "王大帅",
                "hereditary": "王",
                "middle_name": "大",
                "secondary": "王",
                "social": "ii",
                "tertiary": "王",
                "local_first_name_2": "五",
                "local_middle_name": "大",
                "local_primary": "黄",
                "local_primary_2": "王",
                "local_secondary": "王",
                "title": "mr",
                "local_first_name": "四",
                "custom_local_name": "王大帅",
                "custom_western_name": "王大帅",
                "first_name": "帅",
                "name_primary": "王"
            },
            "additional_name": "王帅",
            "gender": "female",
            "nationality_v2": "6862995757234914826",
            "ethnicity_race": "han",
            "phone": {
                "international_area_code": "86_china",
                "phone_number": "13000000000"
            },
            "email": "1234567@example.feishu.cn",
            "date_of_birth": "2006-01-02",
            "marital_status": "married",
            "is_disabled": false,
            "disable_card_number": "92838277746172888312",
            "is_martyr_family": false,
            "martyr_card_number": "00001",
            "is_old_alone": false,
            "born_country_region": "6862995757234914825",
            "political_affiliation": "other",
            "native_region": "6862995757234914827",
            "date_entered_workforce": "2006-01-02",
            "first_entry_time": "2006-01-02",
            "leave_time": "2006-01-02",
            "custom_fields": [
                {
                    "field_name": "custom_field_1__c",
                    "value": "123"
                }
            ],
            "additional_nationalities": [
                "6862995757234914827"
            ]
        },
        "emergency_contacts": [
            {
                "legal_name": "王大帅",
                "relationship": "parent",
                "is_primary": true,
                "phone": {
                    "international_area_code": "86_china",
                    "phone_number": "13000000000"
                },
                "email": "1234567@example.feishu.cn",
                "address": {
                    "address_type": "home_address",
                    "country_region": "6862995757234914824",
                    "region": "6863326815667095047",
                    "region_subdivision_1": "行政区1",
                    "region_subdivision_2": "行政区2",
                    "city_v2": "6862995757234914829",
                    "city_text": "北京市",
                    "local_city_text": "北京市",
                    "city_subdivision_1": "行政区 1",
                    "city_subdivision_2": "行政区 2",
                    "district_v2": "6862995757234914831",
                    "postal_code": "611530",
                    "address_line_1": "丹佛测试地址 - 纽埃时区",
                    "local_address_line_1": "丹佛测试地址 - 纽埃时区",
                    "address_line_2": "PoewH",
                    "local_address_line_2": "PoewH",
                    "address_line_3": "PoewH",
                    "local_address_line_3": "PoewH",
                    "address_line_4": "jmwJc",
                    "local_address_line_5": "jmwJc",
                    "address_line_6": "jmwJc",
                    "local_address_line_6": "jmwJc",
                    "address_line_7": "jmwJc",
                    "local_address_line_7": "jmwJc",
                    "address_line_8": "jmwJc",
                    "local_address_line_8": "rafSu",
                    "address_line_9": "McPRG",
                    "local_address_line_9": "McPRG",
                    "local_address_line_4": "jmwJc",
                    "address_line_5": "jmwJc"
                },
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ]
            }
        ],
        "bank_accounts": [
            {
                "country_region": "6862995757234914824",
                "bank_name": "中国农业银行",
                "branch_name": "中国农业银行支行",
                "account_holder": "孟十五",
                "bank_account_number": "6231200000001223",
                "bank_account_usages": [
                    "payment"
                ],
                "bank_account_type": "savings",
                "bank_id": "6862995757234914832",
                "branch_id": "6862995757234914833",
                "payment_type": "percent,balance,amount",
                "payment_rate": "80.28",
                "payment_amount": "5000",
                "priority": "1"
            }
        ],
        "nationals": [
            {
                "country_region": "6862995757234914824",
                "national_id_type": "6863330041896371725",
                "national_id_number": "1231131333",
                "issued_date": "2020-04-01",
                "issued_by": "北京市公安局",
                "expiration_date": "2020-05-21",
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ]
            }
        ],
        "resident_taxes": [
            {
                "year_resident_tax": "2006-01-02",
                "tax_country_region": "6862995757234914824",
                "resident_status": "tax_residence",
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ]
            }
        ],
        "dependents": [
            {
                "legal_name": "王大帅",
                "date_of_birth": "2006-01-02",
                "relationship_with_dependent": "parent",
                "gender": "female",
                "phone": {
                    "international_area_code": "86_china",
                    "phone_number": "13000000000"
                },
                "job": "岗位",
                "child_birth_certificates": [
                    {
                        "file_id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200",
                        "mime_type": "zip",
                        "name": "附件.zip",
                        "size": "1000",
                        "token": "0a423bc7ea7c4a439d066bf070616782"
                    }
                ],
                "employer": "飞书",
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ],
                "address": {
                    "address_type": "home_address",
                    "country_region": "6862995757234914824",
                    "region": "6863326815667095047",
                    "region_subdivision_1": "行政区 1",
                    "region_subdivision_2": "行政区 2",
                    "city_v2": "6862995757234914829",
                    "city_text": "北京市",
                    "local_city_text": "北京市",
                    "city_subdivision_1": "行政区 1",
                    "city_subdivision_2": "行政区 2",
                    "district_v2": "6862995757234914831",
                    "postal_code": "611530",
                    "address_line_1": "丹佛测试地址 - 纽埃时区",
                    "local_address_line_1": "丹佛测试地址 - 纽埃时区",
                    "address_line_2": "PoewH",
                    "local_address_line_2": "PoewH",
                    "address_line_3": "PoewH",
                    "local_address_line_3": "PoewH",
                    "address_line_4": "jmwJc",
                    "local_address_line_5": "jmwJc",
                    "address_line_6": "jmwJc",
                    "local_address_line_6": "jmwJc",
                    "address_line_7": "jmwJc",
                    "local_address_line_7": "jmwJc",
                    "address_line_8": "jmwJc",
                    "local_address_line_8": "rafSu",
                    "address_line_9": "McPRG",
                    "local_address_line_9": "McPRG",
                    "local_address_line_4": "jmwJc",
                    "address_line_5": "jmwJc"
                }
            }
        ],
        "hukou": {
            "hukou_type": "local_urban_residence",
            "hukou_location": "北京",
            "custom_fields": [
                {
                    "field_name": "custom_field_1__c",
                    "value": "123"
                }
            ]
        },
        "contact_addresses": [
            {
                "address_type": "home_address",
                "country_region": "6862995757234914824",
                "region": "6863326815667095047",
                "region_subdivision_1": "行政区 1",
                "region_subdivision_2": "行政区 2",
                "city_v2": "6862995757234914829",
                "city_text": "北京市",
                "local_city_text": "北京市",
                "city_subdivision_1": "行政区 1",
                "city_subdivision_2": "行政区 2",
                "district_v2": "6862995757234914831",
                "postal_code": "611530",
                "address_line_1": "丹佛测试地址 - 纽埃时区",
                "local_address_line_1": "丹佛测试地址 - 纽埃时区",
                "address_line_2": "PoewH",
                "local_address_line_2": "PoewH",
                "address_line_3": "PoewH",
                "local_address_line_3": "PoewH",
                "address_line_4": "jmwJc",
                "local_address_line_5": "jmwJc",
                "address_line_6": "jmwJc",
                "local_address_line_6": "jmwJc",
                "address_line_7": "jmwJc",
                "local_address_line_7": "jmwJc",
                "address_line_8": "jmwJc",
                "local_address_line_8": "rafSu",
                "address_line_9": "McPRG",
                "local_address_line_9": "McPRG",
                "local_address_line_4": "jmwJc",
                "address_line_5": "jmwJc"
            }
        ],
        "custom_groups": [
            {
                "group_name": "custom_obj__c",
                "items": [
                    {
                        "custom_fields": [
                            {
                                "field_name": "custom_field_1__c",
                                "value": "123"
                            }
                        ]
                    }
                ]
            }
        ],
        "citizenship_statuses": [
            {
                "country_region": "7324333990030034476",
                "citizenship_status": "公民"
            }
        ]
    },
    "employment_info": {
        "basic_info": {
            "employee_number": "1000000",
            "effective_time": "2021-01-01",
            "regular_employee_start_date": "2021-02-01",
            "seniority_date": "2020-01-01",
            "work_email": "12456@test.com",
            "phone": {
                "international_area_code": "86_china",
                "phone_number": "13000000000"
            },
            "user_geo": "cn",
            "custom_fields": [
                {
                    "field_name": "custom_field_1__c",
                    "value": "123"
                }
            ]
        },
        "probation_info": {
            "probation_start_date": "2021-01-01",
            "probation_expected_end_date": "2021-02-01",
            "actual_probation_end_date": "2021-02-01"
        },
        "employment_record": {
            "employee_type": "6890452208593372679",
            "department": "6890452208593372679",
            "direct_manager": "6893014062142064135",
            "working_hours_type": "6890452208593372600",
            "cost_centers": [
                {
                    "id": "6950635856373745165",
                    "rate": 100
                }
            ],
            "direct_manager_effective_time": "2020-01-01",
            "dotted_line_manager": "6893014062142064136",
            "dotted_line_manager_effective_time": "2020-01-01",
            "job": "6890452208593372679",
            "job_family": "6890452208593372680",
            "job_level": "6890452208593372681",
            "job_grade": "6890452208593372682",
            "work_location": "6890452208593372683",
            "weekly_working_hours": 100,
            "position": "6890452208593372684",
            "pathway": "6890452208593372684"
        },
        "emp_contract_record": {
            "contract_number": "6919737965274990093",
            "contract_type": "labor_contract",
            "first_party": "6892686614112241165",
            "effective_time": "2006-01-02",
            "duration_type": "fixed_term",
            "contract_end_date": "2050-01-01"
        },
        "custom_groups": [
            {
                "group_name": "custom_obj__c",
                "items": [
                    {
                        "custom_fields": [
                            {
                                "field_name": "custom_field_1__c",
                                "value": "123"
                            }
                        ]
                    }
                ]
            }
        ],
        "custom_org_groups": [
            {
                "effective_time": "2024-07-02",
                "start_reason": "新增人员",
                "custom_org_with_rates": [
                    {
                        "id": "7260357352426782739",
                        "rate": 50.1
                    }
                ],
                "object_api_name": "custom_org_01"
            }
        ],
        "seniority_adjust_informations": [
            {
                "seniority_adjustment_type": "increase",
                "start_date": "2024-01-01",
                "end_date": "2024-01-02",
                "reasons_for_seniority_adjustment": "工厂停产需要减去半年工龄",
                "seniority_adjustment": 1.01,
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "[\"custom_enum_0__c\"]"
                    }
                ]
            }
        ],
        "default_cost_center": {
            "reason": "默认成本中心变更",
            "is_inherit": true,
            "cost_center_id": {
                "wk_id": "7382048365313261588"
            }
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
        }
    },
    "career": {
        "educations": [
            {
                "school": "北京大学",
                "school_enum": "school-177",
                "start_date": "2011-09-01",
                "end_date": "2015-06-30",
                "level_of_education": "masters_degree",
                "field_of_study": "软件工程",
                "degree": "bachelors_degree",
                "field_of_study_enum": "field_of_study-2",
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ]
            }
        ],
        "work_experiences": [
            {
                "company_organization": {
                    "zh_cn": "中文名",
                    "en_us": "english name"
                },
                "department": {
                    "zh_cn": "中文名",
                    "en_us": "english name"
                },
                "start_date": "2020-01-01",
                "end_date": "2020-02-01",
                "job": {
                    "zh_cn": "中文名",
                    "en_us": "english name"
                },
                "description": {
                    "zh_cn": "中文名",
                    "en_us": "english name"
                },
                "custom_fields": [
                    {
                        "field_name": "custom_field_1__c",
                        "value": "123"
                    }
                ]
            }
        ],
        "custom_groups": [
            {
                "group_name": "custom_obj__c",
                "items": [
                    {
                        "custom_fields": [
                            {
                                "field_name": "custom_field_1__c",
                                "value": "123"
                            }
                        ]
                    }
                ]
            }
        ]
    },
    "data_attachment": {
        "personal_records": [
            {
                "profile_type": "profile_type_1",
                "files": [
                    {
                        "file_id": "150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200",
                        "mime_type": "zip",
                        "name": "附件.zip",
                        "size": "1000",
                        "token": "0a423bc7ea7c4a439d066bf070616782"
                    }
                ]
            }
        ],
        "custom_groups": [
            {
                "group_name": "custom_obj__c",
                "items": [
                    {
                        "custom_fields": [
                            {
                                "field_name": "custom_field_1__c",
                                "value": "123"
                            }
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}