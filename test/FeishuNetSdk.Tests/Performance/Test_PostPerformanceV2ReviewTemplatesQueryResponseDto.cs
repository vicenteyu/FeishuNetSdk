namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取评估模板配置 响应体
/// <para>接口ID：7351374599659782148</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_template%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ReviewTemplatesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "review_templates": [
            {
                "templates": [
                    {
                        "template_id": "7343513161666707459",
                        "name": {
                            "zh_cn": "体验",
                            "en_us": "Interactive experience"
                        },
                        "stage_type": "leader_review",
                        "review_stage_role": "reviewee"
                    }
                ],
                "units": [
                    {
                        "unit_id": "7343513161666723843",
                        "name": {
                            "zh_cn": "体验",
                            "en_us": "Interactive experience"
                        },
                        "fields": [
                            {
                                "field_id": "7343513161666707459",
                                "name": {
                                    "zh_cn": "体验",
                                    "en_us": "Interactive experience"
                                },
                                "indicator_id": "7343513161666707459",
                                "tag_based_question_id": "7343513161666707459",
                                "objective_text_qustion_title": {
                                    "zh_cn": "体验",
                                    "en_us": "Interactive experience"
                                },
                                "keyresult_text_qustion_title": {
                                    "zh_cn": "体验",
                                    "en_us": "Interactive experience"
                                },
                                "parent_field_id": "7343513161666707459"
                            }
                        ]
                    }
                ],
                "review_template_id": "7343513161666723843",
                "name": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "description": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "status": "enabled"
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2ReviewTemplatesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}