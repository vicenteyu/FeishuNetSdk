namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 员工入职 事件体
/// <para>接口ID：7419214646853222404</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "35569a84329f520cc618112fb42ccc9a",
        "token": "",
        "create_time": "1726211356000",
        "event_type": "directory.employee.created_v1",
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
                    "avatar_240": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=240x240&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_640": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=640x640&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_72": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=72x72&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_origin": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp"
                },
                "custom_field_values": [
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "2",
                            "i18n_value": {
                                "zh_cn": "2"
                            }
                        }
                    },
                    {
                        "field_key": "C-xxxx",
                        "field_type": 1,
                        "text_value": {
                            "default_locale": "ms_my",
                            "default_value": "1",
                            "i18n_value": {
                                "ms_my": "1"
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
                            "default_value": "2",
                            "i18n_value": {
                                "zh_cn": "2"
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
                        "field_key": "C-7128392834016641043",
                        "field_type": 3
                    },
                    {
                        "field_key": "C-7345425455221374996",
                        "field_type": 1,
                        "text_value": {
                            "default_value": "444",
                            "i18n_value": {
                                "zh_cn": "444"
                            }
                        }
                    },
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-7345745729023328276"
                            ],
                            "enum_type": 2
                        },
                        "field_key": "C-7345745729023311892",
                        "field_type": 3
                    }
                ],
                "description": "",
                "dotted_line_leader_ids": [
                    "ou_xxxx"
                ],
                "email": "test2@qq.com",
                "employee_id": "ou_xxxxx",
                "employee_order_in_departments": [
                    {
                        "department_id": "od-xxxx",
                        "order_weight_among_deparments": 1,
                        "order_weight_in_deparment": 0
                    }
                ],
                "is_resigned": false,
                "leader_id": "ou_xxxxxx",
                "mobile": "+86xxxxxxxxx",
                "name": {
                    "another_name": "xxxx",
                    "name": {
                        "default_value": "xxxx",
                        "i18n_value": {
                            "en_us": "",
                            "ja_jp": "",
                            "ms_my": "xxxx",
                            "zh_cn": "xxxx"
                        }
                    }
                }
            },
            "work_info": {
                "employment_type": 1,
                "job_number": "123213",
                "job_title": {
                    "job_title_id": "xxxx"
                },
                "join_date": "2024-09-12",
                "resign_date": "",
                "resign_reason": 0,
                "resign_remark": "",
                "resign_type": 0,
                "staff_status": 1,
                "work_country_or_region": "MDCT00000079",
                "work_place": {
                    "place_id": "xxxxx"
                },
                "work_station": {
                    "default_value": "231321",
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
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}