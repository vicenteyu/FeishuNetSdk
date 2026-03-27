// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PatchApplicationV7ApplicationsByAppIdAbilityBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用能力配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用能力配置 请求体
/// <para>接口ID：7621030901518601175</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-ability/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-ability%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV7ApplicationsByAppIdAbilityBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "web_app": {
        "enable": true,
        "pc_url": "https://open.feishu.cn/",
        "pc_new_page_open_mode": "new_tab",
        "mobile_url": "https://open.feishu.cn/"
    },
    "bot": {
        "enable": true,
        "message_card_callback_url": "https://open.feishu.cn",
        "i18ns": [
            {
                "i18n_key": "zh_cn",
                "get_started_desc": "如何使用机器人"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV7ApplicationsByAppIdAbilityBodyDto>(json);
        Assert.IsNotNull(result);
    }
}