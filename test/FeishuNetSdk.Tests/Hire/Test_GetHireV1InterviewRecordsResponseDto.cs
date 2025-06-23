namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量获取面试评价详细信息 响应体
/// <para>接口ID：7287514613653831708</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/interview/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview_record%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewRecordsResponseDto : TestBase
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
                "id": "6949805467799537964",
                "user_id": "ou_d5a80ec46044e4454036308c8e19dc64",
                "content": "代码能力强，思维逻辑清晰",
                "commit_status": 1,
                "feedback_submit_time": 1582084402092,
                "conclusion": 1,
                "interview_score": {
                    "id": "6949805467799537964",
                    "level": 3,
                    "zh_name": "3",
                    "zh_description": "通过, 能力达到要求, 建议录用",
                    "en_name": "three",
                    "en_description": "Pass, ability to meet the requirements, suggest to hire"
                },
                "assessment_score": {
                    "calculate_type": 1,
                    "score": 1,
                    "full_score": 100
                },
                "question_list": [
                    {
                        "id": "7270798542321666367",
                        "title": {
                            "zh_cn": "你从业几年了？",
                            "en_us": "How long have you been working？"
                        },
                        "description": {
                            "zh_cn": "当时具体是什么情况？",
                            "en_us": "What was the specific situation at that time?"
                        },
                        "content": "没有",
                        "ability_list": [
                            {
                                "id": "7270798542321666366",
                                "name": {
                                    "zh_cn": "创新思维",
                                    "en_us": "Creative Thinking"
                                },
                                "description": {
                                    "zh_cn": "创新思维",
                                    "en_us": "Creative Thinking"
                                }
                            }
                        ]
                    }
                ],
                "code_question_list": [
                    {
                        "id": "7270798542321666367",
                        "title": {
                            "zh_cn": "是否遇到过团队成员没有达到目标的情况",
                            "en_us": "Have you ever encountered a situation where a team member did not meet their goals?"
                        },
                        "description": {
                            "zh_cn": "当时具体是什么情况？",
                            "en_us": "What was the specific situation at that time?"
                        },
                        "content": "没有"
                    }
                ],
                "interviewer": {
                    "id": "ou_bc6dd7d30630700f443193d602841086",
                    "name": {
                        "zh_cn": "赵鹏",
                        "en_us": "Tom cruise"
                    }
                },
                "image_list": [
                    {
                        "id": "7270798542321666364",
                        "url": "https://open.feishu.cn/hire/file/blob/xxxx/",
                        "name": "成绩单",
                        "mime": "image/jpg",
                        "create_time": "1693884103327"
                    }
                ],
                "dimension_assessment_list": [
                    {
                        "id": "6949805467799537964",
                        "name": {
                            "zh_cn": "执行力",
                            "en_us": "Execution capability"
                        },
                        "full_score": 100,
                        "content": "这个候选人还不错",
                        "dimension_id": "11111111",
                        "dimension_score": {
                            "id": "6949805467799537964",
                            "name": {
                                "zh_cn": "选项 1",
                                "en_us": "Option 1"
                            },
                            "score_val": 10
                        },
                        "dimension_score_list": [
                            {
                                "id": "6949805467799537964",
                                "name": {
                                    "zh_cn": "选项 1",
                                    "en_us": "Option 1"
                                }
                            }
                        ],
                        "dimension_custom_score": 10,
                        "ability_list": [
                            {
                                "id": "7270798542321666366",
                                "name": {
                                    "zh_cn": "创新思维",
                                    "en_us": "Creative Thinking"
                                },
                                "description": {
                                    "zh_cn": "创新思维",
                                    "en_us": "Creative Thinking"
                                }
                            }
                        ],
                        "question_list": [
                            {
                                "id": "7270798542321666367",
                                "title": {
                                    "zh_cn": "是否遇到过团队成员没有达到目标的情况",
                                    "en_us": "Have you ever encountered a situation where a team member did not meet their goals?"
                                },
                                "description": {
                                    "zh_cn": "当时具体是什么情况？",
                                    "en_us": "What was the specific situation at that time?"
                                },
                                "content": "没有",
                                "ability_list": [
                                    {
                                        "id": "7270798542321666366",
                                        "name": {
                                            "zh_cn": "创新思维",
                                            "en_us": "Creative Thinking"
                                        },
                                        "description": {
                                            "zh_cn": "创新思维",
                                            "en_us": "Creative Thinking"
                                        }
                                    }
                                ]
                            }
                        ],
                        "dimension_type": 1
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}