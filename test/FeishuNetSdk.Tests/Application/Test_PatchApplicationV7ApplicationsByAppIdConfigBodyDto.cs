// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PatchApplicationV7ApplicationsByAppIdConfigBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用开发配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用开发配置 请求体
/// <para>接口ID：7621030901518617559</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-config/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-config%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV7ApplicationsByAppIdConfigBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope": {
        "add_scopes": [
            {
                "scope_name": "im:message",
                "token_type": "tenant"
            }
        ],
        "remove_scopes": [
            {
                "scope_name": "im:message",
                "token_type": "tenant"
            }
        ]
    },
    "event": {
        "subscription_type": "webhook",
        "request_url": "https://open.feishu.cn/",
        "add_events": [
            "im.chat.updated_v1"
        ],
        "remove_events": [
            "im.chat.updated_v1"
        ]
    },
    "security": {
        "add": {
            "redirect_urls": [
                "https://open.feishu.com/"
            ],
            "allowed_ips": [
                "114.251.196.102"
            ],
            "h5_trusted_domains": [
                "https://open.feishu.com"
            ],
            "web_view_trusted_domains": [
                "https://open.feishu.com"
            ],
            "allowed_schemas": [
                "https://applink.feishu.cn"
            ],
            "allowed_server_domains": [
                "https://open.feishu.com"
            ]
        },
        "remove": {
            "redirect_urls": [
                "https://open.feishu.com/"
            ],
            "allowed_ips": [
                "114.251.196.102"
            ],
            "h5_trusted_domains": [
                "https://open.feishu.com"
            ],
            "web_view_trusted_domains": [
                "https://open.feishu.com"
            ],
            "allowed_schemas": [
                "https://applink.feishu.cn"
            ],
            "allowed_server_domains": [
                "https://open.feishu.com"
            ]
        },
        "allow_refresh_token": false
    },
    "visibility": {
        "is_visible_to_all": false,
        "visible_list": {
            "user_ids": [
                "ou_84aad35d084aa403a838cf73ee18467"
            ],
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ]
        }
    },
    "contacts": {
        "contacts_range_type": "some",
        "visible_list": {
            "user_ids": [
                "ou_7dab8a3d3cdcc9da365777c7ad535d62"
            ],
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ]
        }
    },
    "event_and_callback_encrypt_strategy": {
        "encryption_key": "xE4k2SkQgtbC8jZEviGRxxxxxxxx",
        "verification_token": "lVEjWtBAu6kVIgSLMV3C4fxxxx"
    },
    "callback": {
        "callback_type": "webhook",
        "request_url": "https://open.feishu.cn/callback",
        "add_callbacks": [
            "url.preview.get"
        ],
        "remove_callbacks": [
            "url.preview.get"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV7ApplicationsByAppIdConfigBodyDto>(json);
        Assert.IsNotNull(result);
    }
}