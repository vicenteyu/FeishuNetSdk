// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1EmployeesFilterResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取员工列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取员工列表 响应体
/// <para>接口ID：7359428154233683972</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/filter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2ffilter</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesFilterResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data":
    {
        "employees":
        [
            {
                "base_info":
                {
                    "employee_id": "sddasdeqwe",
                    "name":
                    {
                        "name":
                        {
                            "default_value": "张三",
                            "i18n_value":
                            {
                                "zh_cn": "张三"
                            }
                        },
                        "another_name": "张小明"
                    },
                    "mobile": "+8613011111111",
                    "email": "zhangsan@company.com",
                    "enterprise_email": "zhangsan@company.com",
                    "gender": 1,
                    "departments":
                    [
                        {
                            "department_id": "h12921",
                            "department_count":
                            {
                                "recursive_members_count": "100",
                                "direct_members_count": "100",
                                "recursive_members_count_exclude_leaders": "100",
                                "recursive_departments_count": "100",
                                "direct_departments_count": "100"
                            },
                            "has_child": true,
                            "leaders":
                            [
                                {
                                    "leader_type": 1,
                                    "leader_id": "u273y71"
                                }
                            ],
                            "parent_department_id": "h12921",
                            "name":
                            {
                                "default_value": "张三",
                                "i18n_value":
                                {
                                    "zh_cn": "张三"
                                }
                            },
                            "order_weight": "100",
                            "custom_field_values":
                            [
                                {
                                    "field_key": "C-1000001",
                                    "field_type": 1,
                                    "text_value":
                                    {
                                        "default_value": "张三",
                                        "i18n_value":
                                        {
                                            "zh_cn": "张三"
                                        }
                                    },
                                    "url_value":
                                    {
                                        "link_text":
                                        {
                                            "default_value": "张三",
                                            "i18n_value":
                                            {
                                                "zh_cn": "张三"
                                            }
                                        },
                                        "url": "https://m.bytedance.com/afnasjfna",
                                        "pcurl": "http://www.fs.cn"
                                    },
                                    "enum_value":
                                    {
                                        "enum_ids":
                                        [
                                            "1"
                                        ],
                                        "enum_name": "1",
                                        "enum_type": 1
                                    },
                                    "user_values":
                                    [
                                        {
                                            "ids":
                                            [
                                                "1"
                                            ]
                                        }
                                    ]
                                }
                            ],
                            "department_path_infos":
                            [
                                {
                                    "department_id": "1",
                                    "department_name":
                                    {
                                        "default_value": "张三",
                                        "i18n_value":
                                        {
                                            "zh_cn": "张三"
                                        }
                                    }
                                }
                            ],
                            "data_source": 1
                        }
                    ],
                    "employee_order_in_departments":
                    [
                        {
                            "department_id": "h12921",
                            "order_weight_in_deparment": "100",
                            "order_weight_among_deparments": "100"
                        }
                    ],
                    "description": "新成员请多关照",
                    "active_status": 1,
                    "is_resigned": true,
                    "leader_id": "uyg77nx",
                    "dotted_line_leader_ids":
                    [
                        "asdasdqwe"
                    ],
                    "is_primary_admin": true,
                    "enterprise_email_aliases":
                    [
                        "saqwe@163.com"
                    ],
                    "custom_field_values":
                    [
                        {
                            "field_key": "C-1000001",
                            "field_type": 1,
                            "text_value":
                            {
                                "default_value": "张三",
                                "i18n_value":
                                {
                                    "zh_cn": "张三"
                                }
                            },
                            "url_value":
                            {
                                "link_text":
                                {
                                    "default_value": "张三",
                                    "i18n_value":
                                    {
                                        "zh_cn": "张三"
                                    }
                                },
                                "url": "https://m.bytedance.com/afnasjfna",
                                "pcurl": "http://www.fs.cn"
                            },
                            "enum_value":
                            {
                                "enum_ids":
                                [
                                    "1"
                                ],
                                "enum_name": "选项结果名称",
                                "enum_type": 1
                            },
                            "user_values":
                            [
                                {
                                    "ids":
                                    [
                                        "1"
                                    ]
                                }
                            ]
                        }
                    ],
                    "department_path_infos":
                    [
                        [
                            {
                                "department_id": "1",
                                "department_name":
                                {
                                    "default_value": "张三",
                                    "i18n_value":
                                    {
                                        "zh_cn": "张三"
                                    }
                                }
                            }
                        ]
                    ],
                    "resign_time": "2023-10-01",
                    "avatar":
                    {
                        "avatar_72": "http://qwed.com",
                        "avatar_240": "http://wssd.com",
                        "avatar_640": "http://wssd.com",
                        "avatar_origin": "https:inernal-api/image"
                    },
                    "background_image": "http://sadui.com",
                    "is_admin": true,
                    "data_source": 1,
                    "geo_name": "china",
                    "subscription_ids":
                    [
                        "458694723562"
                    ]
                },
                "work_info":
                {
                    "work_country_or_region": "MDCT00000012",
                    "work_place":
                    {
                        "place_id": "place100",
                        "place_name":
                        {
                            "default_value": "张三",
                            "i18n_value":
                            {
                                "zh_cn": "张三"
                            }
                        },
                        "is_enabled": true,
                        "description":
                        {
                            "default_value": "张三",
                            "i18n_value":
                            {
                                "zh_cn": "张三"
                            }
                        }
                    },
                    "work_station":
                    {
                        "default_value": "张三",
                        "i18n_value":
                        {
                            "zh_cn": "张三"
                        }
                    },
                    "job_number": "2845435",
                    "extension_number": "2845435",
                    "join_date": "2007-03-20",
                    "employment_type": 1,
                    "staff_status": 1,
                    "job_title":
                    {
                        "job_title_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                        "job_title_name":
                        {
                            "default_value": "张三",
                            "i18n_value":
                            {
                                "zh_cn": "张三"
                            }
                        },
                        "is_enabled": true,
                        "description":
                        {
                            "default_value": "张三",
                            "i18n_value":
                            {
                                "zh_cn": "张三"
                            }
                        }
                    },
                  "job_family": {
                        "description": {
                            "default_value": ""
                        },
                        "is_enabled": true,
                        "job_family_id": "5rbknygz18kv2ge",
                        "job_family_name": {
                            "default_value": "QAcese1",
                            "i18n_value": {
                                "en_us": "cese1",
                                "ja_jp": "cese土豆1",
                                "zh_cn": "测试1"
                            }
                        },
                        "parent_job_family_id": "0"
                    }
                }
            }
        ],
        "page_response":
        {
            "has_more": true,
            "page_token": "sdefsd"
        },
        "abnormals":
        [
            {
                "row_error": 0,
                "field_errors":
                {
                    "base_info.mobile": "1000"
                },
                "id": "eedasfwe"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.PostDirectoryV1EmployeesFilterResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}