// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PutOkrV2ObjectivesByObjectiveIdKeyResultsWeightResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改关键结果权重 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 修改关键结果权重 响应体
/// <para>接口ID：7644764969658502092</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective/key_results_weight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective%2fkey_results_weight</para>
/// </summary>
[TestClass]
public class Test_PutOkrV2ObjectivesByObjectiveIdKeyResultsWeightResponseDto : TestBase
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
                "objective_id": "7342342398472398472",
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
                "weight": 0.5,
                "deadline": "1760604634563"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PutOkrV2ObjectivesByObjectiveIdKeyResultsWeightResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}