// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostOkrV2CyclesByCycleIdObjectivesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建 OKR 目标 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 创建 OKR 目标 请求体
/// <para>接口ID：7644863390543973340</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle-objective/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle-objective%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostOkrV2CyclesByCycleIdObjectivesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": {
        "blocks": [
            {
                "block_element_type": "paragraph",
                "paragraph": {
                    "style": {
                        "list": {
                            "list_type": "number",
                            "indent_level": 1,
                            "number": 1
                        }
                    },
                    "elements": [
                        {
                            "paragraph_element_type": "textRun",
                            "text_run": {
                                "text": "周报内容",
                                "style": {
                                    "bold": true,
                                    "strike_through": true,
                                    "back_color": {
                                        "red": 216,
                                        "green": 191,
                                        "blue": 188,
                                        "alpha": 0.1
                                    },
                                    "text_color": {
                                        "red": 216,
                                        "green": 191,
                                        "blue": 188,
                                        "alpha": 0.1
                                    },
                                    "link": {
                                        "url": "open.feishu.cn"
                                    }
                                }
                            },
                            "docs_link": {
                                "url": "open.feishu.cn",
                                "title": "百度"
                            },
                            "mention": {
                                "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                            }
                        }
                    ]
                },
                "gallery": {
                    "images": [
                        {
                            "file_token": "boxcnOj88GDkmWGm2zsTyCBqoLb",
                            "src": "https://bytedance.feishu.cn/drive/home/",
                            "width": 458,
                            "height": 372
                        }
                    ]
                }
            }
        ]
    },
    "notes": {
        "blocks": [
            {
                "block_element_type": "paragraph",
                "paragraph": {
                    "style": {
                        "list": {
                            "list_type": "number",
                            "indent_level": 1,
                            "number": 1
                        }
                    },
                    "elements": [
                        {
                            "paragraph_element_type": "textRun",
                            "text_run": {
                                "text": "周报内容",
                                "style": {
                                    "bold": true,
                                    "strike_through": true,
                                    "back_color": {
                                        "red": 216,
                                        "green": 191,
                                        "blue": 188,
                                        "alpha": 0.1
                                    },
                                    "text_color": {
                                        "red": 216,
                                        "green": 191,
                                        "blue": 188,
                                        "alpha": 0.1
                                    },
                                    "link": {
                                        "url": "open.feishu.cn"
                                    }
                                }
                            },
                            "docs_link": {
                                "url": "open.feishu.cn",
                                "title": "百度"
                            },
                            "mention": {
                                "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                            }
                        }
                    ]
                },
                "gallery": {
                    "images": [
                        {
                            "file_token": "boxcnOj88GDkmWGm2zsTyCBqoLb",
                            "src": "https://bytedance.feishu.cn/drive/home/",
                            "width": 458,
                            "height": 372
                        }
                    ]
                }
            }
        ]
    },
    "deadline": "1760604634563",
    "weight": 0.5,
    "category_id": "7342342398472398473",
    "score": 0.5
}
""";
        var result = Deserialize<FeishuNetSdk.Okr.PostOkrV2CyclesByCycleIdObjectivesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}