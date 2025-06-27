// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2ReviewDatasQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取绩效详情数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取绩效详情数据 响应体
/// <para>接口ID：7351374599659847684</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ReviewDatasQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "datas": [
            {
                "user_id": {
                    "open_id": "od-asd2dasdasd",
                    "user_id": "ou-ux987dsf6x"
                },
                "semester_id": "7343513161666707459",
                "activity_id": "7343513161666707459",
                "review_template_id": "7343513161666707459",
                "stages": [
                    {
                        "stage_id": "7343513161666707459",
                        "stage_type": "review",
                        "template_id": "7343513161666707459",
                        "records": [
                            {
                                "progress": 1,
                                "units": [
                                    {
                                        "unit_id": "7343513161666707459",
                                        "is_unknown": false,
                                        "data": [
                                            {
                                                "field_id": "7343513161666707459",
                                                "reviewer_user_id": {
                                                    "open_id": "od-asd2dasdasd",
                                                    "user_id": "ou-ux987dsf6x"
                                                },
                                                "submit_time": "7343513161666707459",
                                                "indicator_id": "7343513161666707459",
                                                "option_id": "7343513161666707459",
                                                "score": "1.1",
                                                "text": "qwert",
                                                "tag_based_question_id": "7343513161666707459",
                                                "tag_text_item_data": [
                                                    {
                                                        "tag_text_id": "7343513161666707459",
                                                        "tag_text": "qwertyu",
                                                        "tag_richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}"
                                                    }
                                                ],
                                                "perf_coefficient_value": "1.1",
                                                "sub_indicator_data": [
                                                    {
                                                        "field_id": "7343513161666707459",
                                                        "indicator_id": "7343513161666707459",
                                                        "option_id": "7343513161666707459",
                                                        "score": "1.1",
                                                        "text": "qwertyuiop",
                                                        "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}"
                                                    }
                                                ],
                                                "objective_data": [
                                                    {
                                                        "objective_id": "7343513161666707459",
                                                        "score": "1.1",
                                                        "text": "qwertyu",
                                                        "keyresult_data": [
                                                            {
                                                                "keyresult_id": "7343513161666707459",
                                                                "score": "1.1",
                                                                "text": "qwerty",
                                                                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}"
                                                            }
                                                        ],
                                                        "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}"
                                                    }
                                                ],
                                                "metric_data": [
                                                    {
                                                        "id": "7343513161666707459",
                                                        "score": "1.1"
                                                    }
                                                ],
                                                "leader_review_data_source": "review",
                                                "multi_texts": [
                                                    "qwerty"
                                                ],
                                                "richtext": "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}",
                                                "multi_richtexts": [
                                                    "{\"ops\":[{\"name\":\"insert\",\"text\":\"qwerty\"}]}"
                                                ],
                                                "is_principal_review_item": true
                                            }
                                        ]
                                    }
                                ],
                                "invited_review_record_info": {
                                    "reviewer_id": {
                                        "open_id": "od-asd2dasdasd",
                                        "user_id": "ou-ux987dsf6x"
                                    },
                                    "is_rejected": false,
                                    "rejected_reason": "test",
                                    "distribute_type": 1,
                                    "avg_diff": "1.23",
                                    "relationship_with_reviewee": "direct_report",
                                    "invitedby": "system_default"
                                },
                                "direct_project_leader_record_info": {
                                    "reviewer_id": {
                                        "open_id": "od-asd2dasdasd",
                                        "user_id": "ou-ux987dsf6x"
                                    },
                                    "cooperation_projects": [
                                        {
                                            "id": "7309457114076807188",
                                            "name": {
                                                "zh_cn": "体验",
                                                "en_us": "Interactive experience"
                                            },
                                            "roles": [
                                                {
                                                    "reviewer_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    },
                                                    "reviewee_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    }
                                                }
                                            ],
                                            "user_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ],
                                            "underling_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ]
                                        }
                                    ],
                                    "review_depend_projects": [
                                        {
                                            "id": "7309457114076807188",
                                            "name": {
                                                "zh_cn": "体验",
                                                "en_us": "Interactive experience"
                                            },
                                            "roles": [
                                                {
                                                    "reviewer_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    },
                                                    "reviewee_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    }
                                                }
                                            ],
                                            "user_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ],
                                            "underling_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ]
                                        }
                                    ],
                                    "participated_projects": [
                                        {
                                            "id": "7309457114076807188",
                                            "name": {
                                                "zh_cn": "体验",
                                                "en_us": "Interactive experience"
                                            },
                                            "roles": [
                                                {
                                                    "reviewer_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    },
                                                    "reviewee_role": {
                                                        "role_id": "7213434603057807379",
                                                        "name": {
                                                            "zh_cn": "体验",
                                                            "en_us": "Interactive experience"
                                                        }
                                                    }
                                                }
                                            ],
                                            "user_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ],
                                            "underling_roles": [
                                                {
                                                    "role_id": "7213434603057807379",
                                                    "name": {
                                                        "zh_cn": "体验",
                                                        "en_us": "Interactive experience"
                                                    }
                                                }
                                            ]
                                        }
                                    ]
                                },
                                "record_id": "7385000219907457024-7385000219907457025"
                            }
                        ],
                        "review_stage_role": "reviewee"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2ReviewDatasQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}