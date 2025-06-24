// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1JobsByJobIdConfigResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取职位设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位设置 响应体
/// <para>接口ID：7172190705011212292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/config</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fconfig</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobsByJobIdConfigResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "job_config": {
            "offer_apply_schema": {
                "id": "7392444731470563625",
                "name": {
                    "zh_cn": "申请表1",
                    "en_us": "Offer Apply 1"
                }
            },
            "offer_process_conf": {
                "id": "7392444731470563625",
                "name": {
                    "zh_cn": "审批流程1",
                    "en_us": "Test Process 1"
                }
            },
            "recommended_evaluator_list": [
                {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "张三",
                        "en_us": "ZhangSan"
                    }
                }
            ],
            "assessment_template": {
                "id": "7392444731470563625",
                "name": {
                    "zh_cn": "评价表1",
                    "en_us": "assessment_template·1"
                }
            },
            "id": "6960663240925956574",
            "interview_round_list": [
                {
                    "interviewer_list": [
                        {
                            "id": "7392444731470563625",
                            "name": {
                                "zh_cn": "张三",
                                "en_us": "ZhangSan"
                            }
                        }
                    ],
                    "round": 1
                }
            ],
            "job_requirement_list": [
                {
                    "id": "6949805467799537964",
                    "name": {
                        "zh_cn": "华中大区部门",
                        "en_us": "JR Test"
                    }
                }
            ],
            "interview_registration": {
                "schema_id": "6930815272790114324",
                "name": "默认登记表"
            },
            "onboard_registration": {
                "schema_id": "6930815272790114324",
                "name": "默认登记表"
            },
            "interview_round_type_list": [
                {
                    "assessment_round": {
                        "id": "7392444731470563625",
                        "name": {
                            "zh_cn": "测试类型",
                            "en_us": "Test type"
                        }
                    },
                    "assessment_template": {
                        "id": "7392444731470563625",
                        "name": {
                            "zh_cn": "测试评价表",
                            "en_us": "Test Name"
                        }
                    }
                }
            ],
            "related_job_list": [
                {
                    "id": "7392444731470563625",
                    "name": {
                        "zh_cn": "职位1",
                        "en_us": "job1"
                    }
                }
            ],
            "job_attribute": 1,
            "interview_appointment_config": {
                "enable_interview_appointment_by_interviewer": true,
                "config": {
                    "interview_type": 1,
                    "talent_timezone_code": "Asia/Shanghai",
                    "contact_user_id": "ou_c99c5f35d542efc7ee492afe11af19ef",
                    "contact_mobile": "177xxxx1773",
                    "contact_email": "test@open.com",
                    "address_id": "6960663240925956576",
                    "video_type": 1,
                    "cc": [
                        "ou_c99c5f35d542efc7ee492afe11af19ef"
                    ],
                    "remark": "这个职位最好选择现场牛客网面试",
                    "interview_notification_template_id": "6960663240925956573",
                    "appointment_notification_template_id": "6960663240925956573",
                    "cancel_interview_notification_template_id": "6960663240925956573"
                }
            },
            "portal_website_apply_form_schema_info": {
                "schema_id": "6930815272790114324",
                "name": "默认申请表"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobsByJobIdConfigResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}