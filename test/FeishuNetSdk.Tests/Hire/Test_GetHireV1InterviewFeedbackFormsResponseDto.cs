// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1InterviewFeedbackFormsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取面试评价表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试评价表列表 响应体
/// <para>接口ID：7356428725080342530</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_feedback_form%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewFeedbackFormsResponseDto : TestBase
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
                "id": "6969137186734393644",
                "version": 1,
                "name": {
                    "zh_cn": "默认面试评价表",
                    "en_us": "default interview assessment template"
                },
                "type": 1,
                "score_calculation_config": {
                    "enabled": true,
                    "calculation_mode": 1
                },
                "modules": [
                    {
                        "id": "6930815272790114324",
                        "name": {
                            "zh_cn": "默认面试评价表模块",
                            "en_us": "default interview assessment module"
                        },
                        "description": {
                            "zh_cn": "用于填写面试评价",
                            "en_us": "for completing interview evaluation"
                        },
                        "type": 1,
                        "sequence": 1,
                        "weight": 1,
                        "dimensions": [
                            {
                                "id": "6930815272790114324",
                                "name": {
                                    "zh_cn": "默认评价维度",
                                    "en_us": "default dimension"
                                },
                                "description": {
                                    "zh_cn": "可以用于完整评价的维度",
                                    "en_us": "dimensions that can be used for a complete evaluation"
                                },
                                "type": 1,
                                "enabled": true,
                                "sequence": 1,
                                "is_required": true,
                                "weight": 1,
                                "score_dimension_config": {
                                    "score_dimension_type": 1,
                                    "lower_limit_score": 1,
                                    "upper_limit_score": 100
                                },
                                "option_items": [
                                    {
                                        "id": "6930815272790114324",
                                        "name": {
                                            "zh_cn": "默认选项",
                                            "en_us": "default option"
                                        },
                                        "description": {
                                            "zh_cn": "以选择题的方式评价候选人",
                                            "en_us": "evaluation of candidates by multiple choice questions"
                                        },
                                        "score_val": 1
                                    }
                                ],
                                "display_not_evident": true,
                                "ability_list": [
                                    {
                                        "id": "6930815272790114324",
                                        "name": {
                                            "zh_cn": "默认能力项",
                                            "en_us": "default ability"
                                        },
                                        "description": {
                                            "zh_cn": "用于评价候选人专业能力",
                                            "en_us": "for evaluating the professional competence of candidates"
                                        }
                                    }
                                ]
                            }
                        ]
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewFeedbackFormsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}