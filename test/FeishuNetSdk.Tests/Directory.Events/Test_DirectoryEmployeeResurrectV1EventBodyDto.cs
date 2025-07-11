// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DirectoryEmployeeResurrectV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 离职恢复在职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 离职恢复在职 事件体
/// <para>接口ID：7419214646853074948</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fresurrect</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeResurrectV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "e40f4582d66aac6daa20ca0bd0d26fc2",
        "token": "",
        "create_time": "1726196988000",
        "event_type": "directory.employee.resurrect_v1",
        "tenant_key": "133c1eae3c0f1748",
        "app_id": "cli_a23f3400fe78901b"
    },
    "event": {
        "abnormal": {
            "row_error": 0
        },
        "employee": {
            "base_info": {
                "active_status": 5,
                "avatar": {
                    "avatar_240": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_df99dd3d-9270-481e-a773-9b76c095b9aj~?image_size=240x240&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_640": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_df99dd3d-9270-481e-a773-9b76c095b9aj~?image_size=640x640&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_72": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_df99dd3d-9270-481e-a773-9b76c095b9aj~?image_size=72x72&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_origin": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_df99dd3d-9270-481e-a773-9b76c095b9aj~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp"
                },
                "custom_field_values": [
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-xxxx"
                            ],
                            "enum_type": 1
                        },
                        "field_key": "C-xxxx",
                        "field_type": 3
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "444",
                            "i18n_value": {
                            }
                        }
                    },
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-xxxx"
                            ],
                            "enum_type": 2
                        },
                        "field_key": "C-xxxx",
                        "field_type": 3
                    },
                    {
                        "field_key": "C-7347670470596509716",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "2",
                            "i18n_value": {
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "1",
                            "i18n_value": {
                            }
                        }
                    },
                    {
                        "field_key": "C-7086364739001221140",
                        "field_type": 1,
                        "text_value": {
                            "default_locale": "ms_my",
                            "default_value": "2",
                            "i18n_value": {
                                "ms_my": "2"
                            }
                        }
                    },
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-xxxx"
                            ],
                            "enum_type": 1
                        },
                        "field_key": "C-xxxx",
                        "field_type": 3
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 2,
                        "url_value": {
                            "link_text": {
                                "default_value": "Feishu",
                                "i18n_value": {
                                }
                            },
                            "url": "https://www.feishu.cn/"
                        }
                    },
                    {
                        "field_key": "C-7392575061963882516",
                        "field_type": 1,
                        "text_value": {
                            "default_locale": "ms_my",
                            "default_value": "2",
                            "i18n_value": {
                                "ms_my": "2"
                            }
                        }
                    }
                ],
                "description": "",
                "dotted_line_leader_ids": [
                    "ou_xxxx"
                ],
                "email": "test2@qq.com",
                "employee_id": "ou_xxxx",
                "employee_order_in_departments": [
                    {
                        "department_id": "od-xxxx",
                        "order_weight_among_deparments": 1,
                        "order_weight_in_deparment": 0
                    }
                ],
                "departments": [
                    {
                        "department_id": "od-xxxxx"
                    }
                ],
                "is_resigned": false,
                "leader_id": "ou_xxxx",
                "mobile": "+86133xxxxxxxx",
                "name": {
                    "another_name": "xxxx",
                    "name": {
                        "default_value": "xxxx",
                        "i18n_value": {
                            "en_us": "",
                            "ja_jp": "",
                            "zh_cn": "xxxx"
                        }
                    }
                }
            },
            "work_info": {
                "employment_type": 1,
                "job_number": "123213",
                "job_title": {
                    "job_title_id": "vrrlmnxn8jbj2p7"
                },
                "join_date": "2024-09-12",
                "resign_date": "",
                "resign_reason": 0,
                "resign_remark": "",
                "resign_type": 0,
                "staff_status": 1,
                "work_country_or_region": "MDCT00000079",
                "work_place": {
                    "place_id": "xxxx"
                },
                "work_station": {
                    "default_value": "xxxx",
                    "i18n_value": {
                        "en_us": "",
                        "ja_jp": "",
                        "zh_cn": "231321"
                    }
                }
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeResurrectV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}