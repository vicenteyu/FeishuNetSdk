// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPersonalSettingsV1SystemStatusesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建系统状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 创建系统状态 响应体
/// <para>接口ID：7161608966368821251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostPersonalSettingsV1SystemStatusesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "system_status": {
            "system_status_id": "7101214603622940633",
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
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.PersonalSettings.PostPersonalSettingsV1SystemStatusesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}