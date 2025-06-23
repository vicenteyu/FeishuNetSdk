namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 修改系统状态 请求体
/// <para>接口ID：7161608966368739331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchPersonalSettingsV1SystemStatusesBySystemStatusIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "system_status": {
        "title": "出差",
        "i18n_title": {
            "zh_cn": "出差",
            "en_us": "On business trip",
            "ja_jp": "出張中"
        },
        "icon_key": "GeneralBusinessTrip",
        "color": "BLUE",
        "priority": 1,
        "sync_setting": {
            "is_open_by_default": true,
            "title": "出差期间自动开启",
            "i18n_title": {
                "zh_cn": "出差期间自动开启",
                "en_us": "Auto display Business Trip",
                "ja_jp": "出張中に自動的にオンにする"
            },
            "explain": "出差审批通过后，将自动开启并优先展示该状态。",
            "i18n_explain": {
                "zh_cn": "出差审批通过后，该状态将自动开启并优先展示",
                "en_us": "Auto-display after travel request is approved.",
                "ja_jp": "申請が承認されると、このステータスが優先的に表示されます"
            }
        }
    },
    "update_fields": [
        "ICON"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.PersonalSettings.PatchPersonalSettingsV1SystemStatusesBySystemStatusIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}