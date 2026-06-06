// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PutOkrV2CyclesByCycleIdObjectivesWeightResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改 OKR 目标权重 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 修改 OKR 目标权重 响应体
/// <para>接口ID：7644764969658338252</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle/objectives_weight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle%2fobjectives_weight</para>
/// </summary>
[TestClass]
public class Test_PutOkrV2CyclesByCycleIdObjectivesWeightResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "7342342398472398473",
                "create_time": "1760604634563",
                "update_time": "1760604634563",
                "owner": {
                    "owner_type": "user",
                    "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674"
                },
                "cycle_id": "7342342398472398473",
                "position": 1,
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
                "score": 0.5,
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
                "weight": 0.5,
                "deadline": "1760604634563",
                "category_id": "7342342398472398473"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PutOkrV2CyclesByCycleIdObjectivesWeightResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}