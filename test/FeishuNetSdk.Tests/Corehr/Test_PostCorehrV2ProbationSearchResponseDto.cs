namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索试用期信息 响应体
/// <para>接口ID：7254814386694553602</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationSearchResponseDto : TestBase
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
                "employment_id": "6893014062142064135",
                "probation_id": "6893014062142064132",
                "probation_start_date": "2022-05-20",
                "probation_expected_end_date": "2022-05-28",
                "actual_probation_end_date": "2022-06-28",
                "initiating_time": "2022-07-28",
                "submission_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "initiator_id": "6893014062142061135",
                "probation_status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "self_review": "符合预期",
                "notes": "高潜",
                "process_id": "6893014062142164135",
                "converted_via_bpm": false,
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ],
                "final_assessment_status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "final_assessment_result": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "final_assessment_score": 99.9,
                "final_assessment_grade": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "final_assessment_comment": "超出预期",
                "final_assessment_detail": "https://qwe112233.feishuapp.bytedance.net/ae/ui/apps//122265873393330/recordPages/1/records/1767139312?objectId=17661180522543&recordPageId=173330728118312",
                "assessments": [
                    {
                        "assessment_id": "6893014061142064135",
                        "assessment_status": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "assessment_result": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "assessment_score": 99.9,
                        "assessment_grade": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "assessment_comment": "超出预期",
                        "assessment_detail": "https://qwe1123433.feishuapp.bytedance.net/ae/ui/apps//122265871113330/recordPages/2/records/17611111112?objectId=17663333322543&recordPageId=171128122312",
                        "is_final_asssessment": false
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ProbationSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}