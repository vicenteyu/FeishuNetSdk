// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2PreHiresByPreHireIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新待入职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新待入职信息 请求体
/// <para>接口ID：7357756972752715778</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2PreHiresByPreHireIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "basic_info_update": {
        "names": [
            {
                "full_name": "李一一",
                "first_name": "一",
                "middle_name": "一",
                "name_primary": "李",
                "local_first_name": "一",
                "local_middle_name": "一",
                "local_primary": "李",
                "custom_local_name": "李一一",
                "custom_western_name": "YiyiLi",
                "country_region": "6862995757234914824",
                "name_type": "legal_name",
                "additional_name": "别名"
            }
        ],
        "phones": [
            {
                "international_area_code": "86_china",
                "phone_number": "010-12345678",
                "device_type": "mobile_phone",
                "phone_usage": "work",
                "is_primary": true,
                "is_public": true
            }
        ],
        "emails": [
            {
                "email": "1234567@bytedance.com",
                "is_primary": true,
                "is_public": true,
                "email_usage": "work"
            }
        ],
        "nationality_v2_id": "6862995757234914824",
        "additional_nationality_id_list": [
            "6862995757234914824"
        ],
        "resident_tax_list": [
            {
                "tax_country_region": "6862995757234914824",
                "resident_status": "tax_residence",
                "tax_address": {
                    "country_region_id": "6862995757234914824",
                    "region_id": "6863326815667095047",
                    "local_address_line1": "北京市海淀区",
                    "local_address_line2": "上海市杨浦区",
                    "local_address_line3": "北京市房山区",
                    "local_address_line4": "天津滨海高新区",
                    "local_address_line5": "成都市成华区",
                    "local_address_line6": "深圳市南山区",
                    "local_address_line7": "南京市鼓楼区",
                    "local_address_line8": "杭州市滨江区",
                    "local_address_line9": "郑州市中原区",
                    "postal_code": "611530",
                    "address_types": [
                        "home_address"
                    ],
                    "is_primary": true,
                    "is_public": true,
                    "city_id_v2": "6863333254578046471",
                    "district_id_v2": "6863333516579440141"
                },
                "resident_status_specification": "文本内容，对纳税身份的补充说明信息",
                "year_resident_tax": "2006-01-01",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "born_country_region": "6862995757234914824",
        "is_disabled": true,
        "disable_card_number": "身份证号+残疾类型（1-7）+ 残疾程度分级（1-4）+[补发编号]",
        "is_old_alone": true,
        "is_martyr_family": true,
        "martyr_card_number": "00001",
        "dependent_list": [
            {
                "relationship": "parent",
                "gender": "male",
                "date_of_birth": "2020-01-01",
                "national_ids": [
                    {
                        "country_region_id": "6862995757234914824",
                        "national_id_type_id": "6863330041896371725",
                        "national_id_number": "1231131333",
                        "issue_date": "2020-04-01",
                        "expiration_date": "2020-05-21",
                        "issued_by": "北京市公安局",
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "Sandy"
                            }
                        ]
                    }
                ],
                "spouses_working_status": "working",
                "is_this_person_covered_by_health_insurance": true,
                "is_this_person_allowed_for_tax_deduction": false,
                "dependent_name": "王冰",
                "employer": "海淀区交警大队",
                "job": "保安",
                "phone": {
                    "international_area_code": "86_china",
                    "phone_number": "010-12345678",
                    "device_type": "mobile_phone",
                    "phone_usage": "home",
                    "is_primary": true,
                    "is_public": true
                },
                "address": {
                    "country_region_id": "6862995757234914824",
                    "region_id": "6863326815667095047",
                    "local_address_line1": "北京市海淀区",
                    "local_address_line2": "上海市杨浦区",
                    "local_address_line3": "北京市房山区",
                    "local_address_line4": "天津滨海高新区",
                    "local_address_line5": "成都市成华区",
                    "local_address_line6": "深圳市南山区",
                    "local_address_line7": "南京市鼓楼区",
                    "local_address_line8": "杭州市滨江区",
                    "local_address_line9": "郑州市中原区",
                    "postal_code": "611530",
                    "address_types": [
                        "home_address"
                    ],
                    "is_primary": true,
                    "is_public": true,
                    "city_id_v2": "6863333254578046471",
                    "district_id_v2": "6863333516579440141"
                },
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "religion": "buddism",
        "bank_account_list": [
            {
                "bank_name": "中国农业银行",
                "branch_name": "中国农业银行支行",
                "bank_account_number": "6231200000001223",
                "account_holder": "孟十五",
                "country_region_id": "6862995745889322510",
                "bank_account_usages": [
                    "payment"
                ],
                "bank_account_type": "checking",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "national_id_list": [
            {
                "country_region_id": "6862995757234914824",
                "national_id_type_id": "6863330041896371725",
                "national_id_number": "1231131333",
                "issue_date": "2020-04-01",
                "expiration_date": "2020-05-21",
                "issued_by": "北京市公安局",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "personal_profile_list": [
            {
                "personal_profile_type": "profile_type_1_101_101011",
                "files": [
                    {
                        "id": "6655aa1b2ec326f983b91f9d_f9974583040c4b05ae71f92f5df16bbc"
                    }
                ]
            }
        ],
        "emergency_contact_list": [
            {
                "legal_name": "王冰",
                "relationship": "parent",
                "phones": [
                    {
                        "international_area_code": "86_china",
                        "phone_number": "010-12345678",
                        "device_type": "mobile_phone",
                        "phone_usage": "home",
                        "is_primary": true,
                        "is_public": true
                    }
                ],
                "address": {
                    "country_region_id": "6862995757234914824",
                    "region_id": "6863326815667095047",
                    "local_address_line1": "北京市海淀区",
                    "local_address_line2": "上海市杨浦区",
                    "local_address_line3": "北京市房山区",
                    "local_address_line4": "天津滨海高新区",
                    "local_address_line5": "成都市成华区",
                    "local_address_line6": "深圳市南山区",
                    "local_address_line7": "南京市鼓楼区",
                    "local_address_line8": "杭州市滨江区",
                    "local_address_line9": "郑州市中原区",
                    "postal_code": "611530",
                    "address_types": [
                        "home_address"
                    ],
                    "is_primary": true,
                    "is_public": true,
                    "city_id_v2": "6863333254578046471",
                    "district_id_v2": "6863333516579440141"
                },
                "email": {
                    "email": "1234567@bytedance.com",
                    "is_primary": true,
                    "is_public": true,
                    "email_usage": "work"
                },
                "is_primary": true,
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "address_list": [
            {
                "country_region_id": "6862995757234914824",
                "region_id": "6863326815667095047",
                "local_address_line1": "北京市海淀区",
                "local_address_line2": "上海市杨浦区",
                "local_address_line3": "北京市房山区",
                "local_address_line4": "天津滨海高新区",
                "local_address_line5": "成都市成华区",
                "local_address_line6": "深圳市南山区",
                "local_address_line7": "南京市鼓楼区",
                "local_address_line8": "杭州市滨江区",
                "local_address_line9": "郑州市中原区",
                "postal_code": "611530",
                "address_types": [
                    "home_address"
                ],
                "is_primary": true,
                "is_public": true,
                "city_id_v2": "6863333254578046471",
                "district_id_v2": "6863333516579440141"
            }
        ],
        "marital_status": "single",
        "ethnicity_race": "han",
        "custom_fields": [
            {
                "field_name": "name",
                "value": "Sandy"
            }
        ],
        "native_region": "6862995757234914824",
        "hukou_type": "local_urban_residence",
        "hukou_location": "北京市海淀区北三环西路",
        "gender_id": "male",
        "date_of_birth": "2011-99-99",
        "date_entered_workforce": "2100-09-09",
        "expected_graduate_date": "2023-01-10",
        "citizenship_status_id_list": [
            "6862995757234914824"
        ],
        "work_experience": [
            {
                "company_name": "猎豹",
                "start_time": "2015-02-01",
                "end_time": "2017-02-01",
                "job_title": "产品经理",
                "description": "app",
                "department": "部门名称"
            }
        ],
        "education_info": [
            {
                "school_name": "长安大学",
                "education": "phd",
                "start_time": "2017-04-01",
                "end_time": "2018-04-01",
                "field_of_study": "医学影像技术"
            }
        ]
    },
    "offer_info_update": {
        "onboarding_date": "2022-10-08",
        "ats_application_id": "7140946969586010376",
        "onboarding_location_id": "6977976687350924832",
        "onboarding_address_id": "6977976687350924832",
        "office_location_id": "6977976687350924833",
        "office_address_id": "6977976687350924832",
        "employment_type": "employee",
        "onboarding_method": "onsite",
        "work_emails": [
            {
                "email": "1234567@bytedance.com",
                "is_primary": true,
                "is_public": true,
                "email_usage": "work"
            }
        ],
        "cost_center_rates": [
            {
                "cost_center_id": "6950635856373745165",
                "rate": 100,
                "new_rate": 50.2
            }
        ],
        "custom_fields": [
            {
                "field_name": "name",
                "value": "[\"Sandy\"]"
            }
        ],
        "position_id": "697797668735092768",
        "probation_period": 6,
        "probation_start_date": "2022-07-29",
        "probation_end_date": "2023-04-07",
        "contract_start_date": "2022-10-08",
        "contract_end_date": "2025-10-07",
        "contract_type": "internship_agreement",
        "duration_type_id": "fixed_term",
        "signing_type_id": "new",
        "worker_id": "DDD00001",
        "check_in_time": "2024-12-31",
        "check_in_method": "onsite",
        "company": "6738317738688661772",
        "work_shift": "work_shift",
        "recruitment_type_id": "experienced_professionals",
        "compensation_type": "hourly",
        "pay_group_id": "6977976687350924833",
        "offer_hr_id": "7032210902531327521",
        "job_id": "6977976735715378724",
        "job_family_id": "6977972856625939999",
        "job_level_id": "6977971894960145950",
        "job_grade_id": "6738317738688661772",
        "employee_type_id": "6977973225846343171",
        "employee_subtype_id": "xxx",
        "direct_leader_id": "7032210902531327521",
        "dotted_line_manager_id": "xxx",
        "department_id": "7147562782945478177",
        "social_security_city": "6977976687350924833",
        "work_location_id": "6977976687350924833",
        "working_calendar": "6890452208593372141",
        "working_hours_type": "6890452208593372679",
        "seniority_date": "2022-10-08",
        "seniority_adjust_information_list": [
            {
                "seniority_adjustment": 0.5,
                "seniority_adjustment_type": "增加",
                "reasons_for_seniority_adjustment": "工厂停产需要减去半年工龄",
                "start_date": "2024-05-19",
                "end_date": "2024-11-18",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "Sandy"
                    }
                ]
            }
        ],
        "notice_period_probation_voluntary": {
            "wk_id": "4698019107896524633",
            "value": 1,
            "value_unit": "月"
        },
        "notice_period_probation_involuntary": {
            "wk_id": "4698019107896524633",
            "value": 1,
            "value_unit": "月"
        },
        "notice_period_positive_voluntary": {
            "wk_id": "4698019107896524633",
            "value": 1,
            "value_unit": "月"
        },
        "notice_period_positive_involuntary": {
            "wk_id": "4698019107896524633",
            "value": 1,
            "value_unit": "月"
        },
        "condition_worker": true,
        "company_sponsored_visa": true,
        "weekly_working_hours_v2": 8.5,
        "work_station": "5-1-2",
        "service_company": "6738317738688661772",
        "non_compete_covenant": true,
        "pathway": "7460865381179115052",
        "default_cost_center": {
            "cost_center_id": "6950635856373745165",
            "is_herit": false
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
    "standard_update_fields": [
        "basic_info_update.names"
    ],
    "custom_update_fields": [
        "custom_field1__c"
    ],
    "person_custom_update_fields": [
        "custom_field1__c"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2PreHiresByPreHireIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}