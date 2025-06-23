namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建任务 请求体
/// <para>接口ID：7255580838154371100</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "summary": "针对全年销售进行一次复盘",
    "description": "需要事先阅读复盘总结文档",
    "due": {
        "timestamp": "1675454764000",
        "is_all_day": true
    },
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
    "completed_at": "1675742789470",
    "members": [
        {
            "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
            "type": "user",
            "role": "assignee",
            "name": "张明德（明德）"
        }
    ],
    "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
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
    "tasklists": [
        {
            "tasklist_guid": "cc371766-6584-cf50-a222-c22cd9055004",
            "section_guid": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
        }
    ],
    "client_token": "daa2237f-8310-4707-a83b-52c8a81e0fb7",
    "start": {
        "timestamp": "1675454764000",
        "is_all_day": true
    },
    "reminders": [
        {
            "relative_fire_minute": 30
        }
    ],
    "mode": 2,
    "is_milestone": false,
    "custom_fields": [
        {
            "guid": "73b21903-0041-4796-a11e-f8be919a7063",
            "number_value": "10.23",
            "member_value": [
                {
                    "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                    "type": "user",
                    "name": "张明德（明德）"
                }
            ],
            "datetime_value": "1698192000000",
            "single_select_value": "73b21903-0041-4796-a11e-f8be919a7063",
            "multi_select_value": [
                "73b21903-0041-4796-a11e-f8be919a7063"
            ],
            "text_value": "这是一段文本描述。"
        }
    ],
    "docx_source": {
        "token": "OvZCdFYVHo5ArFxJKHjcnRbtnKd",
        "block_id": "O6wwd22uIoG8acxwxGtbljaUcfc"
    },
    "positive_reminders": [
        {
            "relative_fire_minute": 30
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}