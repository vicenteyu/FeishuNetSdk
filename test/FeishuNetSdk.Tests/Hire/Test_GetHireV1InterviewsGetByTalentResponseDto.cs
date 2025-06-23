namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取人才面试信息 响应体
/// <para>接口ID：7055229817129811969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/get_by_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterview%2fget_by_talent</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewsGetByTalentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [{
            "application_id": "6949805467799537964",
            "interview_list": [{
                "id": "6949805467799537964",
                "begin_time": 1618899376474,
                "end_time": 1618999376474,
                "round": 0,
                "interview_record_list": [{
                    "id": "6949805467799537964",
                    "user_id": "1618899376474",
                    "content": "逻辑严密，代码质量高",
                    "commit_status": 1,
                    "conclusion": 1,
                    "interview_score": {
                        "id": "6949805467799537964",
                        "level": 3,
                        "zh_name": "3",
                        "zh_description": "通过, 能力达到要求, 建议录用",
                        "en_name": "three",
                        "en_description": "Pass, ability to meet the requirements, suggest to hire"
                    },
                    "interviewer": {
                        "id": "ou_266ed047ed37f24554e5a0afdbb15556",
                        "name": {
                            "zh_cn": "段誉",
                            "en_us": "Yu Duan"
                        }
                    }
                }],
                "stage_id": "634324253532232",
                "application_id": "634324253532232",
                "stage": {
                    "id": "634324253532232",
                    "name": {
                        "zh_cn": "待入职",
                        "en_us": "Prehire"
                    }
                },
                "creator": {
                    "id": "ou_266ed047ed37f24554e5a0afdbb15556",
                    "name": {
                        "zh_cn": "段誉",
                        "en_us": "Yu Duan"
                    }
                },
                "biz_create_time": 1618999376474,
                "biz_modify_time": 1618999376474,
                "interview_round_summary": 1,
                "interview_arrangement_id": "634324253532232",
                "interview_type": 1,
                "talent_time_zone": {
                    "code": "Asia/Shanghai",
                    "name": {
                        "zh_cn": "(GMT+08:00) 中国标准时间 - 北京",
                        "en_us": "(GMT+08:00) China Standard Time - Beijing"
                    }
                },
                "contact_user": {
                    "id": "ou_266ed047ed37f24554e5a0afdbb15556",
                    "name": {
                        "zh_cn": "段誉",
                        "en_us": "Yu Duan"
                    }
                },
                "contact_mobile": "13333333333",
                "remark": "test",
                "address": {
                    "id": "6949805467799537964",
                    "name": {
                        "zh_cn": "中国四川成都天府二街155号",
                        "en_us": "No. 155, Tianfu 2nd Street, Chengdu, Sichuan, China"
                    },
                    "district": {
                        "code": "DS_1",
                        "name": {
                            "zh_cn": "武侯区",
                            "en_us": "Wuhou"
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
                "meeting_room_list": [{
                    "room_id": "6949805467799537964",
                    "room_name": "OCG111",
                    "building_name": "OCG",
                    "reserved_status": 1,
                    "floor_name": "17"
                }],
                "interview_round_type": {
                    "id": "6949805467799537964",
                    "name": {
                        "zh_cn": "一面",
                        "en_us": "Round one"
                    }
                }
            }]
        }]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewsGetByTalentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}