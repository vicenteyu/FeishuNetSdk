// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1InterviewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取面试信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取面试信息 响应体
/// <para>接口ID：6989078472837267459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewsResponseDto : TestBase
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
                "id": "6949805467799537964",
                "begin_time": 1618899376474,
                "end_time": 1618999376474,
                "round": 0,
                "interview_record_list": [
                    {
                        "id": "6949805467799537964",
                        "user_id": "1618899376474",
                        "content": "符合要求，推荐录用",
                        "commit_status": 1,
                        "conclusion": 1,
                        "interview_score": {
                            "id": "6949805467799537964",
                            "level": 3,
                            "zh_name": "第一轮面试",
                            "zh_description": "通过，能力达到要求， 建议录用",
                            "en_name": "English name",
                            "en_description": "Pass, ability to meet the requirements, suggest to hire"
                        },
                        "interviewer": {
                            "id": "1213213123123",
                            "name": {
                                "zh_cn": "周小二",
                                "en_us": "Tony Ma"
                            }
                        }
                    }
                ],
                "feedback_submit_time": 1659318415000,
                "stage_id": "634324253532232",
                "application_id": "634324253532232",
                "stage": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "笔试",
                        "en_us": "writing"
                    }
                },
                "creator": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "张二二",
                        "en_us": "Tony Ma"
                    }
                },
                "biz_create_time": 1618999376474,
                "biz_modify_time": 1618999376474,
                "interview_round_summary": 1,
                "interview_arrangement_id": "1111111",
                "interview_type": 1,
                "talent_time_zone": {
                    "code": "UTC+08:00",
                    "name": {
                        "zh_cn": "亚洲/上海",
                        "en_us": "Asia/Shanghai"
                    }
                },
                "contact_user": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "Tony Ma"
                    }
                },
                "contact_mobile": "13333333333",
                "remark": "这是一个备注",
                "address": {
                    "id": "6949805467799537964",
                    "name": {
                        "zh_cn": "中国",
                        "en_us": "China"
                    },
                    "district": {
                        "code": "DS_1",
                        "name": {
                            "zh_cn": "武侯区",
                            "en_us": "Wu Hou"
                        }
                    },
                    "city": {
                        "code": "CT_1",
                        "name": {
                            "zh_cn": "成都",
                            "en_us": "Chengdu"
                        }
                    },
                    "state": {
                        "code": "ST_1",
                        "name": {
                            "zh_cn": "四川省",
                            "en_us": "SiChuan"
                        }
                    },
                    "country": {
                        "code": "CN_1",
                        "name": {
                            "zh_cn": "中国",
                            "en_us": "China"
                        }
                    }
                },
                "video_type": 1,
                "arrangement_status": 1,
                "arrangement_type": 1,
                "arrangement_appointment_kind": 1,
                "meeting_room_list": [
                    {
                        "room_id": "6949805467799537964",
                        "room_name": "OCG111",
                        "building_name": "OCG",
                        "reserved_status": 1,
                        "floor_name": "17"
                    }
                ],
                "interview_round_type": {
                    "id": "1213213123123",
                    "name": {
                        "zh_cn": "第一轮",
                        "en_us": "Round 1"
                    }
                }
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}