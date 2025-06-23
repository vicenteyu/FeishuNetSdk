namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 列取任务列表 响应体
/// <para>接口ID：7255580838154403868</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2TasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "guid": "83912691-2e43-47fc-94a4-d512e03984fa",
                "summary": "进行销售年中总结",
                "description": "进行销售年中总结",
                "due": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "reminders": [
                    {
                        "id": "10",
                        "relative_fire_minute": 30
                    }
                ],
                "creator": {
                    "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                    "type": "user",
                    "role": "assignee"
                },
                "members": [
                    {
                        "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                        "type": "user",
                        "role": "editor"
                    }
                ],
                "completed_at": "1675742789470",
                "attachments": [
                    {
                        "guid": "f860de3e-6881-4ddd-9321-070f36d1af0b",
                        "file_token": "boxcnTDqPaRA6JbYnzQsZ2doB2b",
                        "name": "foo.jpg",
                        "size": 62232,
                        "resource": {
                            "type": "task",
                            "id": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
                        },
                        "uploader": {
                            "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                            "type": "user",
                            "role": "assignee"
                        },
                        "is_cover": false,
                        "uploaded_at": "1675742789470"
                    }
                ],
                "origin": {
                    "platform_i18n_name": {
                        "en_us": "workbench",
                        "zh_cn": "工作台",
                        "zh_hk": "工作臺",
                        "zh_tw": "工作臺",
                        "ja_jp": "作業台",
                        "fr_fr": "Table de travail",
                        "it_it": "banco di lavoro",
                        "de_de": "Werkbank",
                        "ru_ru": "верстак",
                        "th_th": "โต๊ะทำงาน",
                        "es_es": "banco de trabajo",
                        "ko_kr": "작업대"
                    },
                    "href": {
                        "url": "https://www.example.com",
                        "title": "反馈一个问题，需要协助排查"
                    }
                },
                "extra": "dGVzdA==",
                "tasklists": [
                    {
                        "tasklist_guid": "cc371766-6584-cf50-a222-c22cd9055004",
                        "section_guid": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
                    }
                ],
                "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
                "parent_task_guid": "e297ddff-06ca-4166-b917-4ce57cd3a7a0",
                "mode": 2,
                "source": 6,
                "custom_complete": {
                    "pc": {
                        "href": "https://www.example.com",
                        "tip": {
                            "en_us": "workbench",
                            "zh_cn": "工作台",
                            "zh_hk": "工作臺",
                            "zh_tw": "工作臺",
                            "ja_jp": "作業台",
                            "fr_fr": "Table de travail",
                            "it_it": "banco di lavoro",
                            "de_de": "Werkbank",
                            "ru_ru": "верстак",
                            "th_th": "โต๊ะทำงาน",
                            "es_es": "banco de trabajo",
                            "ko_kr": "작업대"
                        }
                    },
                    "ios": {
                        "href": "https://www.example.com",
                        "tip": {
                            "en_us": "workbench",
                            "zh_cn": "工作台",
                            "zh_hk": "工作臺",
                            "zh_tw": "工作臺",
                            "ja_jp": "作業台",
                            "fr_fr": "Table de travail",
                            "it_it": "banco di lavoro",
                            "de_de": "Werkbank",
                            "ru_ru": "верстак",
                            "th_th": "โต๊ะทำงาน",
                            "es_es": "banco de trabajo",
                            "ko_kr": "작업대"
                        }
                    },
                    "android": {
                        "href": "https://www.example.com",
                        "tip": {
                            "en_us": "workbench",
                            "zh_cn": "工作台",
                            "zh_hk": "工作臺",
                            "zh_tw": "工作臺",
                            "ja_jp": "作業台",
                            "fr_fr": "Table de travail",
                            "it_it": "banco di lavoro",
                            "de_de": "Werkbank",
                            "ru_ru": "верстак",
                            "th_th": "โต๊ะทำงาน",
                            "es_es": "banco de trabajo",
                            "ko_kr": "작업대"
                        }
                    }
                },
                "task_id": "t6272302",
                "created_at": "1675742789470",
                "updated_at": "1675742789470",
                "status": "todo",
                "url": "https://applink.feishu.cn/client/todo/detail?guid=70577c8f-91ab-4c91-b359-a21a751054e8&suite_entity_num=t192012",
                "start": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "subtask_count": 1,
                "is_milestone": false,
                "custom_fields": [
                    {
                        "guid": "a4f648d7-76ef-477f-bc8e-0601b5a60093",
                        "type": "number",
                        "number_value": "10.23",
                        "datetime_value": "1687708260000",
                        "member_value": [
                            {
                                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                                "type": "user",
                                "role": "editor"
                            }
                        ],
                        "single_select_value": "4216f79b-3fda-4dc6-a0c4-a16022e47152",
                        "multi_select_value": [
                            "4216f79b-3fda-4dc6-a0c4-a16022e47152"
                        ],
                        "name": "优先级"
                    }
                ],
                "dependencies": [
                    {
                        "type": "next",
                        "task_guid": "93b7bd05-35e6-4371-b3c9-6b7cbd7100c0"
                    }
                ]
            }
        ],
        "page_token": "aWQ9NzEwMjMzMjMxMDE=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2TasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}