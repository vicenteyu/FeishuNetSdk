namespace FeishuNetSdk.Tests.Contact.Events;

/// <summary>
/// 测试 员工信息被修改 事件体
/// <para>接口ID：6954228303264055323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ContactUserUpdatedV3EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "contact.user.updated_v3",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "object": {
            "open_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "union_id": "on_576833b917gda3d939b9a3c2d53e72c8",
            "user_id": "e33ggbyz",
            "name": "张三",
            "en_name": "San Zhang",
            "nickname": "Sunny Zhang",
            "email": "zhangsan@gmail.com",
            "enterprise_email": "demo@mail.com",
            "job_title": "软件工程师",
            "mobile": "12345678910",
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
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ],
            "leader_user_id": "ou_3ghm8a2u0eftg0ff377125s5dd275z09",
            "city": "杭州",
            "country": "中国",
            "work_station": "杭州",
            "join_time": 1615381702,
            "employee_no": "e33ggbyz",
            "employee_type": 1,
            "orders": [
                {
                    "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                    "user_order": 100,
                    "department_order": 100,
                    "is_primary_dept": true
                }
            ],
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
            "job_level_id": "mga5oa8ayjlp9rb",
            "job_family_id": "mga5oa8ayjlp9rb",
            "dotted_line_leader_user_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ]
        },
        "old_object": {
            "open_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "union_id": "on_576833b917gda3d939b9a3c2d53e72c8",
            "user_id": "e33ggbyz",
            "name": "张三",
            "en_name": "San Zhang",
            "nickname": "Sunny Zhang",
            "email": "zhangsan@gmail.com",
            "job_title": "软件工程师",
            "mobile": "12345678910",
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
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ],
            "leader_user_id": "ou_3ghm8a2u0eftg0ff377125s5dd275z09",
            "city": "杭州",
            "country": "中国",
            "work_station": "杭州",
            "join_time": 1615381702,
            "employee_no": "e33ggbyz",
            "employee_type": 1,
            "orders": [
                {
                    "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                    "user_order": 100,
                    "department_order": 100,
                    "is_primary_dept": true
                }
            ],
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
            "job_level_id": "mga5oa8ayjlp9rb",
            "job_family_id": "mga5oa8ayjlp9rb",
            "dotted_line_leader_user_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Contact.Events.ContactUserUpdatedV3EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}