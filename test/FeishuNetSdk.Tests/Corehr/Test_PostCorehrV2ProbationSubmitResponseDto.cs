namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起转正 响应体
/// <para>接口ID：7254814386694635522</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsubmit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationSubmitResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "probation_info": {
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
                    "value": "231"
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
            "final_assessment_detail": "暂无示例"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2ProbationSubmitResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}