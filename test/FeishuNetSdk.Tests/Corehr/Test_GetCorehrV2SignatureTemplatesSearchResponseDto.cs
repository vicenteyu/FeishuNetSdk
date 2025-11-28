// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_GetCorehrV2SignatureTemplatesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取电子签模板内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取电子签模板内容 响应体
/// <para>接口ID：7395391068203089948</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_template_info_with_thumbnail/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_template%2fsearch</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2SignatureTemplatesSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "signature_templates": [
            {
                "id": "7246307700768902956",
                "brief_info": {
                    "id": "1",
                    "label": [
                        {
                            "lang": "zh-CN",
                            "value": "合同续约模板"
                        }
                    ],
                    "category": {
                        "enum_name": "contract_agreement",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "人事合同 / 协议"
                            }
                        ]
                    },
                    "usage": {
                        "enum_name": "offboarding",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "离职"
                            }
                        ]
                    },
                    "signatory_labels": [
                        {
                            "template_signatory_type": {
                                "enum_name": "Person",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "apiname": "status"
                        }
                    ],
                    "active": true,
                    "create_by": "123123123123123123",
                    "modify_by": "7287500478366090796",
                    "applicability": {
                        "enum_name": "signature",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "电子签"
                            }
                        ]
                    },
                    "creation_method": "online_edit",
                    "version": "v1",
                    "update_time": "31231232123",
                    "create_time": "3123123211",
                    "template_setting": {
                        "page_seal_types": [
                            "page_seal"
                        ]
                    },
                    "template_region_info": {
                        "is_global_scope": "global",
                        "meta_infos": [
                            {
                                "api_name": "7246307700768902956",
                                "wk_id": "7246307700768902956",
                                "label": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            }
                        ]
                    },
                    "template_code": "7246307700768902956",
                    "template_desc": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "content_info": {
                    "contents": [
                        {
                            "content_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "filter_apiname": "111",
                            "content": "111",
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "content_desc": "111"
                        }
                    ],
                    "custom_fields": [
                        {
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "apiname": "status",
                            "custom_field_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "used": true,
                            "is_required": true,
                            "custom_desc": "desc",
                            "common_info": {
                                "source": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "apiname": "status"
                            }
                        }
                    ],
                    "filter_fields": [
                        {
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "apiname": "status",
                            "filters": [
                                {
                                    "left": "aa",
                                    "rights": [
                                        "1"
                                    ],
                                    "op": {
                                        "enum_name": "phone_type",
                                        "display": [
                                            {
                                                "lang": "zh-CN",
                                                "value": "中文示例"
                                            }
                                        ]
                                    }
                                }
                            ],
                            "logic": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "is_checked": true,
                            "filter_desc": "desc",
                            "criterion_list": "[]"
                        }
                    ],
                    "using_fields": [
                        {
                            "source": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "apiname": "status"
                        }
                    ],
                    "system_setting_fields": [
                        {
                            "field_type": {
                                "enum_name": "phone_type",
                                "display": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ]
                            },
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ],
                            "common_info": {
                                "source": {
                                    "enum_name": "System",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                },
                                "apiname": "status"
                            },
                            "combination_info": {
                                "total_apiname": "status",
                                "apiname": "status",
                                "title": [
                                    {
                                        "lang": "zh-CN",
                                        "value": "中文示例"
                                    }
                                ],
                                "contents": [
                                    [
                                        {
                                            "field_type": {
                                                "enum_name": "phone_type",
                                                "display": [
                                                    {
                                                        "lang": "zh-CN",
                                                        "value": "中文示例"
                                                    }
                                                ]
                                            },
                                            "info": {
                                                "source": {
                                                    "enum_name": "System",
                                                    "display": [
                                                        {
                                                            "lang": "zh-CN",
                                                            "value": "中文示例"
                                                        }
                                                    ]
                                                },
                                                "apiname": "status"
                                            },
                                            "label": [
                                                {
                                                    "lang": "zh-CN",
                                                    "value": "中文示例"
                                                }
                                            ]
                                        }
                                    ]
                                ],
                                "source": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                }
                            },
                            "children": "无需关注",
                            "combination_info_v2": {
                                "total_apiname": "弃用，无需关注",
                                "apiname": "弃用，无需关注",
                                "source": {
                                    "enum_name": "phone_type",
                                    "display": [
                                        {
                                            "lang": "zh-CN",
                                            "value": "中文示例"
                                        }
                                    ]
                                }
                            }
                        }
                    ]
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2SignatureTemplatesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}