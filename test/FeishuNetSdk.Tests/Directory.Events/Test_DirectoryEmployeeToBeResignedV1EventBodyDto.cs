// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DirectoryEmployeeToBeResignedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 员工被设置为待离职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 员工被设置为待离职 事件体
/// <para>接口ID：7419214646853124100</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/to_be_resigned</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fto_be_resigned</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeToBeResignedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "bdb54c21f094c20dfbcbf6aa995e2545",
        "token": "",
        "create_time": "1726211351000",
        "event_type": "directory.employee.to_be_resigned_v1",
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
                    "avatar_240": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_a1a8606b-fe92-4426-b1d3-7c999eb578dj~?image_size=240x240&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_640": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_a1a8606b-fe92-4426-b1d3-7c999eb578dj~?image_size=640x640&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_72": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_a1a8606b-fe92-4426-b1d3-7c999eb578dj~?image_size=72x72&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_origin": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_00el_a1a8606b-fe92-4426-b1d3-7c999eb578dj~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp"
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
                            "default_value": "23131",
                            "i18n_value": {
                                "ms_my": "23131"
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "123123",
                            "i18n_value": {
                                "ms_my": "123123"
                            }
                        }
                    },
                    {
                        "field_key": "C-7347690052249534484",
                        "field_type": 2,
                        "url_value": {
                            "link_text": {
                                "default_locale": "ms_my",
                                "default_value": "Feishu",
                                "i18n_value": {
                                    "ms_my": "Feishu"
                                }
                            },
                            "url": "https://www.feishu.cn/"
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "213213",
                            "i18n_value": {
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
                            "default_value": "231231",
                            "i18n_value": {
                                "ms_my": "231231"
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "21321312",
                            "i18n_value": {
                                "ms_my": "21321312"
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "213123",
                            "i18n_value": {
                                "ms_my": "213123"
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
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "21312",
                            "i18n_value": {
                            }
                        }
                    }
                ],
                "description": "",
                "dotted_line_leader_ids": [
                    "ou_xxxx"
                ],
                "email": "test1@qq.com",
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
                "mobile": "+8613011112222",
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
                "job_number": "1111",
                "job_title": {
                    "job_title_id": "8rrl2m8mn7jb157"
                },
                "join_date": "2024-09-12",
                "resign_date": "2024-12-22",
                "resign_reason": 1,
                "resign_remark": "3123213",
                "resign_type": 1,
                "staff_status": 5,
                "work_country_or_region": "MDCT00000040",
                "work_place": {
                    "place_id": "z1rxe3peznm3nk0"
                },
                "work_station": {
                    "default_value": "11111",
                    "i18n_value": {
                        "en_us": "",
                        "ja_jp": "",
                        "zh_cn": "11111"
                    }
                }
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeToBeResignedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}