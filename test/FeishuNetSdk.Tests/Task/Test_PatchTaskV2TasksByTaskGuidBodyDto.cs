// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="Test_PatchTaskV2TasksByTaskGuidBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新任务 请求体
/// <para>接口ID：7255580838154879004</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2TasksByTaskGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "task": {
        "summary": "针对全年销售进行一次复盘",
        "description": "需要事先阅读复盘总结文档",
        "due": {
            "timestamp": "1675454764000",
            "is_all_day": true
        },
        "extra": "dGVzdA==",
        "completed_at": "1675742789470",
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
        "start": {
            "timestamp": "1675454764000",
            "is_all_day": true
        },
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
                "text_value": "文本类型字段值。可以输入一段文本。空字符串表示清空。"
            }
        ]
    },
    "update_fields": [
        "summary"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2TasksByTaskGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}