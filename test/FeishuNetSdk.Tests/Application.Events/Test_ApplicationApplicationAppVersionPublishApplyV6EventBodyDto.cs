// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ApplicationApplicationAppVersionPublishApplyV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 申请发布应用 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application.Events;

/// <summary>
/// 测试 申请发布应用 事件体
/// <para>接口ID：7005118068771405827</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/publish_apply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fevents%2fpublish_apply</para>
/// </summary>
[TestClass]
public class Test_ApplicationApplicationAppVersionPublishApplyV6EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "application.application.app_version.publish_apply_v6",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "online_version": {
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
                "应用审核事件"
            ],
            "status": 1,
            "create_time": "1610462759",
            "publish_time": "1610462759",
            "ability": {
                "gadget": {
                    "enable_pc_mode": 1,
                    "schema_urls": [
                        "*:*"
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
                            {
                                "union_id": "on_8ed6aa67826108097d9ee143816345",
                                "user_id": "e33ggbyz",
                                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                            }
                        ],
                        "department_ids": [
                            "od-ddee42c0f8a948a5e650341e2153243b"
                        ]
                    },
                    "invisible_list": {
                        "open_ids": [
                            {
                                "union_id": "on_8ed6aa67826108097d9ee143816345",
                                "user_id": "e33ggbyz",
                                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                            }
                        ],
                        "department_ids": [
                            "od-ddee42c0f8a948a5e650341e2153243b"
                        ]
                    }
                }
            }
        },
        "under_audit_version": {
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
                "应用审核事件"
            ],
            "status": 1,
            "create_time": "1610462759",
            "publish_time": "1610462759",
            "ability": {
                "gadget": {
                    "enable_pc_mode": 1,
                    "schema_urls": [
                        "*:*"
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
                            {
                                "union_id": "on_8ed6aa67826108097d9ee143816345",
                                "user_id": "e33ggbyz",
                                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                            }
                        ],
                        "department_ids": [
                            "od-ddee42c0f8a948a5e650341e2153243b"
                        ]
                    },
                    "invisible_list": {
                        "open_ids": [
                            {
                                "union_id": "on_8ed6aa67826108097d9ee143816345",
                                "user_id": "e33ggbyz",
                                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                            }
                        ],
                        "department_ids": [
                            "od-ddee42c0f8a948a5e650341e2153243b"
                        ]
                    }
                }
            }
        },
        "app_status": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Application.Events.ApplicationApplicationAppVersionPublishApplyV6EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}