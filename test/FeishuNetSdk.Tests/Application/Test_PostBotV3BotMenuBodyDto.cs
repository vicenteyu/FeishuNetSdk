// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-30
//
// Last Modified By : yxr
// Last Modified On : 2026-10-30
// ************************************************************************
// <copyright file="Test_PostBotV3BotMenuBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建千人千面菜单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 创建千人千面菜单 请求体
/// <para>接口ID：7570924844655640595</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bot-v3/bot_menu/set_bot_menu</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fbot-v3%2fbot_menu%2fset_bot_menu</para>
/// </summary>
[TestClass]
public class Test_PostBotV3BotMenuBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
    "bot_menu": {
        "bot_menu_id": "1",
        "bot_menu_items": [
            {
                "name": "测试按钮",
                "i18n_name": {
                    "en_us": "New topic"
                },
                "icon": {
                    "ud_icon": {
                        "token": "add_outlined",
                        "color": "blue"
                    },
                    "file_key": "img_xxxx"
                },
                "tag": "kkk111",
                "behaviors": [
                    {
                        "type": "target",
                        "target": {
                            "common_url": "https://www.google.com",
                            "ios_url": "https://www.google.com",
                            "android_url": "https://www.google.com",
                            "pc_url": "https://www.google.com",
                            "web_url": "https://www.google.com"
                        },
                        "event_key": "xxx",
                        "is_primary": false
                    }
                ],
                "children": [
                    {
                        "name": "测试按钮",
                        "i18n_name": {
                            "en_us": "New topic"
                        },
                        "icon": {
                            "ud_icon": {
                                "token": "add_outlined",
                                "color": "blue"
                            },
                            "file_key": "img_v3_02xxxxxxxx"
                        },
                        "tag": "kkk111",
                        "behaviors": [
                            {
                                "type": "target",
                                "target": {
                                    "common_url": "https://www.google.com",
                                    "ios_url": "https://www.google.com",
                                    "android_url": "https://www.google.com",
                                    "pc_url": "https://www.google.com",
                                    "web_url": "https://www.google.com"
                                },
                                "event_key": "xxx",
                                "is_primary": false
                            }
                        ],
                        "children": [
                            {
                                "name": "测试按钮",
                                "i18n_name": {
                                    "en_us": "New topic"
                                },
                                "icon": {
                                    "ud_icon": {
                                        "token": "add_outlined",
                                        "color": "blue"
                                    },
                                    "file_key": "img_v3_02xxxxxxxx"
                                },
                                "tag": "kkk111",
                                "behaviors": {
                                    "type": "target",
                                    "target": {
                                        "common_url": "https://www.google.com",
                                        "ios_url": "https://www.google.com",
                                        "android_url": "https://www.google.com",
                                        "pc_url": "https://www.google.com",
                                        "web_url": "https://www.google.com"
                                    },
                                    "event_key": "xxx",
                                    "is_primary": false
                                }
                            }
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostBotV3BotMenuBodyDto>(json);
        Assert.IsNotNull(result);
    }
}