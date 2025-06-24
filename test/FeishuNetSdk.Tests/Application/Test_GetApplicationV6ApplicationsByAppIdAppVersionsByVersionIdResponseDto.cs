// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取应用版本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用版本信息 响应体
/// <para>接口ID：6989432329400287233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "app_version": {
            "app_id": "cli_9f3ca975326b501b",
            "version": "1.0.0",
            "version_id": "oav_d317f090b7258ad0372aa53963cda70d",
            "app_name": "应用名称",
            "avatar_url": "https://www.example.com",
            "description": "应用描述",
            "scopes": [
                {
                    "scope": "contact:user.base",
                    "description": "获取应用信息",
                    "level": 1,
                    "token_types": [
                        "user"
                    ]
                }
            ],
            "back_home_url": "https://www.example.com",
            "i18n": [
                {
                    "i18n_key": "zh_cn",
                    "name": "应用名称",
                    "description": "应用描述",
                    "help_use": "https://www.example.com"
                }
            ],
            "common_categories": [
                "分析工具"
            ],
            "events": [
                "contacts.open_platform.depart"
            ],
            "status": 1,
            "create_time": "1610462759",
            "publish_time": "1610462759",
            "ability": {
                "gadget": {
                    "enable_pc_mode": 1,
                    "schema_urls": [
                        "https://www.example.com"
                    ],
                    "pc_use_mobile_pkg": false,
                    "pc_version": "1.0.0",
                    "mobile_version": "1.0.0",
                    "mobile_min_lark_version": "2.0",
                    "pc_min_lark_version": "2.0"
                },
                "web_app": {
                    "pc_url": "https://www.example.com",
                    "mobile_url": "https://www.example.com"
                },
                "bot": {
                    "card_request_url": "https://www.example.com"
                },
                "workplace_widgets": [
                    {
                        "min_lark_version": "1.0.0"
                    }
                ],
                "navigate": {
                    "pc": {
                        "version": "1.0.0",
                        "image_url": "https://www.example.com",
                        "hover_image_url": "https://www.example.com"
                    },
                    "mobile": {
                        "version": "1.0.0",
                        "image_url": "https://www.example.com",
                        "hover_image_url": "https://www.example.com"
                    }
                },
                "cloud_doc": {
                    "space_url": "https://www.example.com",
                    "i18n": [
                        {
                            "i18n_key": "zh_cn",
                            "name": "名称",
                            "read_description": "读权限说明",
                            "write_description": "写权限说明"
                        }
                    ],
                    "icon_url": "https://www.example.com",
                    "mode": 1
                },
                "docs_blocks": [
                    {
                        "block_type_id": "blk_4fb61568435880110854c1d0",
                        "i18n": [
                            {
                                "i18n_key": "zh_cn",
                                "name": "名称"
                            }
                        ],
                        "mobile_icon_url": "https://www.example.com",
                        "pc_icon_url": "https://www.example.com"
                    }
                ],
                "message_action": {
                    "pc_app_link": "https://www.example.com",
                    "mobile_app_link": "https://www.example.com",
                    "i18n": [
                        {
                            "i18n_key": "zh_cn",
                            "name": "名称"
                        }
                    ]
                },
                "plus_menu": {
                    "pc_app_link": "https://www.example.com",
                    "mobile_app_link": "https://www.example.com"
                }
            },
            "remark": {
                "remark": "备注说明",
                "update_remark": "更新说明",
                "visibility": {
                    "is_all": false,
                    "visible_list": {
                        "open_ids": [
                            "ou_4065981088f8ef67a504ba8bd6b24d85"
                        ],
                        "department_ids": [
                            "od-4b4a6907ad726ea07b27b0d2882b7c65"
                        ],
                        "group_ids": [
                            "b6d1g5dd6fd26186"
                        ]
                    },
                    "invisible_list": {
                        "open_ids": [
                            "ou_4065981088f8ef67a504ba8bd6b24d85"
                        ],
                        "department_ids": [
                            "od-4b4a6907ad726ea07b27b0d2882b7c65"
                        ],
                        "group_ids": [
                            "b6d1g5dd6fd26186"
                        ]
                    }
                }
            },
            "event_infos": [
                {
                    "event_type": "im.chat.updated_v1",
                    "event_name": "群配置修改事件",
                    "event_description": "群聊名称、头像、描述以及群编辑权限、群分享权限等被修改时推送事件"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}