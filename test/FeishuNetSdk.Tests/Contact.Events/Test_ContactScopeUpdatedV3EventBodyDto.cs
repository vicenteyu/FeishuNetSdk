namespace FeishuNetSdk.Tests.Contact.Events;

/// <summary>
/// 测试 通讯录权限范围变更 事件体
/// <para>接口ID：6954228303264038939</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/scope/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fscope%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ContactScopeUpdatedV3EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "contact.scope.updated_v3",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "added": {
            "departments": [
                {
                    "name": "DemoName",
                    "i18n_name": {
                        "zh_cn": "Demo名称",
                        "ja_jp": "デモ名",
                        "en_us": "Demo Name"
                    },
                    "parent_department_id": "D067",
                    "department_id": "D096",
                    "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "chat_id": "oc_5ad11d72b830411d72b836c20",
                    "order": "100",
                    "unit_ids": [
                        "custom_unit_id"
                    ],
                    "member_count": 100,
                    "status": {
                        "is_deleted": false
                    },
                    "leaders": [
                        {
                            "leaderType": 1,
                            "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                        }
                    ],
                    "group_chat_employee_types": [
                        1,2,3
                    ],
                    "primary_member_count": 100
                }
            ],
            "users": [
                {
                    "union_id": "on_94a1ee5551019f18cd73d9f111898cf2",
                    "user_id": "3e3cf96b",
                    "open_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "name": "张三",
                    "en_name": "San Zhang",
                    "nickname": "Alex Zhang",
                    "email": "zhangsan@gmail.com",
                    "mobile": "130xxxx1111",
                    "gender": 1,
                    "avatar": {
                        "avatar_72": "https://foo.icon.com/xxxx",
                        "avatar_240": "https://foo.icon.com/xxxx",
                        "avatar_640": "https://foo.icon.com/xxxx",
                        "avatar_origin": "https://foo.icon.com/xxxx"
                    },
                    "status": {
                        "is_frozen": false,
                        "is_resigned": false,
                        "is_activated": true,
                        "is_exited": false,
                        "is_unjoin": false
                    },
                    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "city": "杭州",
                    "country": "CN",
                    "work_station": "北楼-H34",
                    "join_time": 2147483647,
                    "employee_no": "1",
                    "employee_type": 1,
                    "custom_attrs": [
                        {
                            "type": "TEXT",
                            "id": "DemoId",
                            "value": {
                                "text": "DemoText",
                                "url": "http://www.fs.cn",
                                "pc_url": "http://www.fs.cn",
                                "option_id": "edcvfrtg",
                                "option_value": "option",
                                "name": "name",
                                "picture_url": "https://xxxxxxxxxxxxxxxxxx",
                                "generic_user": {
                                    "id": "9b2fabg5",
                                    "type": 1
                                }
                            }
                        }
                    ],
                    "enterprise_email": "demo@mail.com",
                    "job_title": "xxxxx",
                    "is_frozen": false,
                    "job_level_id": "mga5oa8ayjlp9rb",
                    "job_family_id": "mga5oa8ayjlp9rb",
                    "subscription_ids": [
                        "7179609168571645971"
                    ],
                    "assign_info": [
                        {
                            "subscription_id": "7079609167680782300",
                            "license_plan_key": "suite_enterprise_e5",
                            "product_name": "旗舰版 E5",
                            "i18n_name": {
                                "zh_cn": "zh_cn_name",
                                "ja_jp": "ja_jp_name",
                                "en_us": "en_name"
                            },
                            "start_time": "1674981000",
                            "end_time": "1674991000"
                        }
                    ],
                    "department_path": [
                        {
                            "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                            "department_name": {
                                "name": "测试部门名1",
                                "i18n_name": {
                                    "zh_cn": "Demo名称",
                                    "ja_jp": "デモ名",
                                    "en_us": "Demo Name"
                                }
                            },
                            "department_path": {
                                "department_ids": [
                                    "od-4e6ac4d14bcd5071a37a39de902c7141"
                                ],
                                "department_path_name": {
                                    "name": "测试部门名1",
                                    "i18n_name": {
                                        "zh_cn": "Demo名称",
                                        "ja_jp": "デモ名",
                                        "en_us": "Demo Name"
                                    }
                                }
                            }
                        }
                    ]
                }
            ],
            "user_groups": [
                {
                    "user_group_id": "test",
                    "name": "userGroupName",
                    "type": 1,
                    "member_count": 10,
                    "status": 1
                }
            ]
        },
        "removed": {
            "departments": [
                {
                    "name": "DemoName",
                    "i18n_name": {
                        "zh_cn": "Demo名称",
                        "ja_jp": "デモ名",
                        "en_us": "Demo Name"
                    },
                    "parent_department_id": "D067",
                    "department_id": "D096",
                    "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "chat_id": "oc_5ad11d72b830411d72b836c20",
                    "order": "100",
                    "unit_ids": [
                        "custom_unit_id"
                    ],
                    "member_count": 100,
                    "status": {
                        "is_deleted": false
                    },
                    "leaders": [
                        {
                            "leaderType": 1,
                            "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                        }
                    ],
                    "group_chat_employee_types": [
                        1,2,3
                    ],
                    "primary_member_count": 100
                }
            ],
            "users": [
                {
                    "union_id": "on_94a1ee5551019f18cd73d9f111898cf2",
                    "user_id": "3e3cf96b",
                    "open_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "name": "张三",
                    "en_name": "San Zhang",
                    "nickname": "Alex Zhang",
                    "email": "zhangsan@gmail.com",
                    "mobile": "130xxxx1111",
                    "gender": 1,
                    "avatar": {
                        "avatar_72": "https://foo.icon.com/xxxx",
                        "avatar_240": "https://foo.icon.com/xxxx",
                        "avatar_640": "https://foo.icon.com/xxxx",
                        "avatar_origin": "https://foo.icon.com/xxxx"
                    },
                    "status": {
                        "is_frozen": false,
                        "is_resigned": false,
                        "is_activated": true,
                        "is_exited": false,
                        "is_unjoin": false
                    },
                    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                    "city": "杭州",
                    "country": "CN",
                    "work_station": "北楼-H34",
                    "join_time": 2147483647,
                    "employee_no": "1",
                    "employee_type": 1,
                    "custom_attrs": [
                        {
                            "type": "TEXT",
                            "id": "DemoId",
                            "value": {
                                "text": "DemoText",
                                "url": "http://www.fs.cn",
                                "pc_url": "http://www.fs.cn",
                                "option_id": "edcvfrtg",
                                "option_value": "option",
                                "name": "name",
                                "picture_url": "https://xxxxxxxxxxxxxxxxxx",
                                "generic_user": {
                                    "id": "9b2fabg5",
                                    "type": 1
                                }
                            }
                        }
                    ],
                    "enterprise_email": "demo@mail.com",
                    "job_title": "xxxxx",
                    "is_frozen": false,
                    "job_level_id": "mga5oa8ayjlp9rb",
                    "job_family_id": "mga5oa8ayjlp9rb",
                    "subscription_ids": [
                        "7179609168571645971"
                    ],
                    "assign_info": [
                        {
                            "subscription_id": "7079609167680782300",
                            "license_plan_key": "suite_enterprise_e5",
                            "product_name": "旗舰版 E5",
                            "i18n_name": {
                                "zh_cn": "zh_cn_name",
                                "ja_jp": "ja_jp_name",
                                "en_us": "en_name"
                            },
                            "start_time": "1674981000",
                            "end_time": "1674991000"
                        }
                    ],
                    "department_path": [
                        {
                            "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                            "department_name": {
                                "name": "测试部门名1",
                                "i18n_name": {
                                    "zh_cn": "Demo名称",
                                    "ja_jp": "デモ名",
                                    "en_us": "Demo Name"
                                }
                            },
                            "department_path": {
                                "department_ids": [
                                    "od-4e6ac4d14bcd5071a37a39de902c7141"
                                ],
                                "department_path_name": {
                                    "name": "测试部门名1",
                                    "i18n_name": {
                                        "zh_cn": "Demo名称",
                                        "ja_jp": "デモ名",
                                        "en_us": "Demo Name"
                                    }
                                }
                            }
                        }
                    ]
                }
            ],
            "user_groups": [
                {
                    "user_group_id": "test",
                    "name": "userGroupName",
                    "type": 1,
                    "member_count": 10,
                    "status": 1
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Contact.Events.ContactScopeUpdatedV3EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}