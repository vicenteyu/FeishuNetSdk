namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 待离职恢复为在职 事件体
/// <para>接口ID：7419214646853173252</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/regular</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fregular</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeRegularV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "cb1315992a8545190aece434f3c5a082",
        "token": "",
        "create_time": "1726146320000",
        "event_type": "directory.employee.regular_v1",
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
                    "avatar_origin": "v3_00el_a1a8606b-fe92-4426-b1d3-7c999eb578dj"
                },
                "custom_field_values": [
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "213123",
                            "i18n_value": {
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "123123",
                            "i18n_value": {
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 2,
                        "url_value": {
                            "link_text": {
                                "default_value": "231123",
                                "i18n_value": {
                                }
                            },
                            "url": "https://ufu6y83ytj.feishu-boe.cn/admin/contacts/departmentanduser?"
                        }
                    },
                    {
                        "field_key": "C-7090440828405268500",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "21312",
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
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_locale": "ms_my",
                            "default_value": "21321312",
                            "i18n_value": {
                                "ms_my": "21321312"
                            }
                        }
                    },
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-7128392834016657427"
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
                            "default_locale": "ms_my",
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
                            "default_locale": "ms_my",
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
                            "default_locale": "ms_my",
                            "default_value": "213213",
                            "i18n_value": {
                                "ms_my": "213213"
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
                "mobile": "+86130xxxxxxxx",
                "name": {
                    "another_name": "xxxx",
                    "name": {
                        "default_value": "xxx",
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
                "staff_status": 1,
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
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeRegularV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}