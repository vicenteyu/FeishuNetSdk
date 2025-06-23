namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标列表 响应体
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricLibsQueryResponseDto : TestBase
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
                "metric_id": "7272581996315099155",
                "name": "销售额",
                "type_id": "7272578300650717203",
                "tags": [
                    {
                        "tag_id": "7302271694582841364",
                        "tag_name": {
                            "zh_cn": "体验",
                            "en_us": "Interactive experience"
                        }
                    }
                ],
                "fields": [
                    {
                        "field_id": "7296701873237786643",
                        "input_setting": "admin",
                        "field_value": "90",
                        "field_value_person": {
                            "open_id": "od-asd2dasdasd",
                            "user_id": "ou-ux987dsf6x"
                        }
                    }
                ],
                "scoring_setting_type": "score_by_formula",
                "scoring_formula": {
                    "formula_id": "7302271694582841364",
                    "formula_name": "示例公式",
                    "formula_details": "1 + 1"
                },
                "data_source_inputters": [
                    {
                        "open_id": "od-asd2dasdasd",
                        "user_id": "ou-ux987dsf6x"
                    }
                ],
                "range_of_availability": "admins_and_reviewees",
                "is_active": true
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2MetricLibsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}