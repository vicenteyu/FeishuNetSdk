// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV2InterviewRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取面试评价详细信息（新版） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量获取面试评价详细信息（新版） 响应体
/// <para>接口ID：7356428725080375298</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/interview/list-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhire-v2%2finterview_record%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV2InterviewRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "items": [
            {
                "id": "7171693733661327361",
                "feedback_form_id": "71716937336613273612",
                "commit_status": 1,
                "submit_time": "1710405457390",
                "record_score": {
                    "score": 100.00,
                    "total_score": 100.00
                },
                "interviewer": {
                    "id": "7171693733661327364",
                    "name": {
                        "zh_cn": "小明",
                        "en_us": "xiaoming"
                    }
                },
                "attachments": [
                    {
                        "file_id": "7140517838785481004",
                        "file_name": "1.13测试1的面试记录.pdf",
                        "content_type": "application/pdf",
                        "file_size": 16615,
                        "create_time": "1710399930151"
                    }
                ],
                "module_assessments": [
                    {
                        "interview_feedback_form_module_id": "7171693733661327361",
                        "module_name": {
                            "zh_cn": "面试结论",
                            "en_us": "Interview Result"
                        },
                        "module_type": 1,
                        "module_weight": 10.00,
                        "module_score": 10.00,
                        "dimension_assessments": [
                            {
                                "interview_feedback_form_dimension_id": "7171693733661327361",
                                "dimension_name": {
                                    "zh_cn": "行业知识储备水平",
                                    "en_us": "Industry knowledge reserve level"
                                },
                                "dimension_type": 1,
                                "weight": 1.00,
                                "dimension_content": "描述题作答",
                                "dimension_option": {
                                    "id": "7171693733661327361",
                                    "name": {
                                        "zh_cn": "选项一",
                                        "en_us": "Option 1"
                                    },
                                    "score_val": 10
                                },
                                "dimension_options": [
                                    {
                                        "id": "7171693733661327361",
                                        "name": {
                                            "zh_cn": "选项一",
                                            "en_us": "Option 1"
                                        },
                                        "score_val": 10
                                    }
                                ],
                                "dimension_score": 10,
                                "recommended_job_level": {
                                    "lower_limit_job_level_name": {
                                        "zh_cn": "2-2",
                                        "en_us": "2-2"
                                    },
                                    "higher_limit_job_level_name": {
                                        "zh_cn": "3-2",
                                        "en_us": "3-2"
                                    }
                                },
                                "question_assessments": [
                                    {
                                        "question_type": 1,
                                        "title": {
                                            "zh_cn": "操作系统进程调度",
                                            "en_us": "Operating system process scheduling"
                                        },
                                        "description": {
                                            "zh_cn": "操作系统中如何进行进程调度？",
                                            "en_us": "How is process scheduling performed in an operating system?"
                                        },
                                        "content": "操作系统的进程调度是通过...",
                                        "abilities": [
                                            {
                                                "name": {
                                                    "zh_cn": "算法",
                                                    "en_us": "Algorithm"
                                                },
                                                "description": {
                                                    "zh_cn": "候选人算法能力如何？",
                                                    "en_us": "What are the candidate’s algorithmic abilities?"
                                                }
                                            }
                                        ]
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV2InterviewRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}