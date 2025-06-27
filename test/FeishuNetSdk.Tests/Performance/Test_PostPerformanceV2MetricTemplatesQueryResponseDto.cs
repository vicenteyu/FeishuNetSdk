// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricTemplatesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取指标模板列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标模板列表 响应体
/// <para>接口ID：7380276358332710913</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_template%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricTemplatesQueryResponseDto : TestBase
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
                "id": "7296488199415660563",
                "name": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "description": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "status": "to_be_configured",
                "is_set_by_group": true,
                "total_metric_score_method": "weight",
                "metric_weight_method": "sum_of_metric_weights_for_each_dimension_equals_100",
                "metric_dimensions": [
                    {
                        "group_id": "7296753366268215316",
                        "metric_dimension_id": "7296753366268215316",
                        "name": {
                            "zh_cn": "体验",
                            "en_us": "Interactive experience"
                        },
                        "evaluation_rule_id_for_each_metric": "7296701873237786643",
                        "dimension_weight": "90",
                        "description": {
                            "zh_cn": "维度描述",
                            "en_us": "Dimension description"
                        },
                        "review_rule_option": 0,
                        "custom_metric_config": {
                            "default_formula_id": "7296701873237786643",
                            "least_metrics_size": 1,
                            "add_metric_options": [
                                1,
                                2
                            ]
                        }
                    }
                ],
                "metrics": [
                    {
                        "group_id": "7272581996315099155",
                        "metric_id": "7272581996315099155",
                        "name": "销售额",
                        "type_id": "7272581996315099155",
                        "fields": [
                            {
                                "id": "7272581996315099155",
                                "input_setting": "admin",
                                "filed_value": "100",
                                "field_value_person": {
                                    "open_id": "od-asd2dasdasd",
                                    "user_id": "ou-ux987dsf6x"
                                }
                            }
                        ],
                        "is_from_library": true,
                        "scoring_setting_type": "score_by_formula",
                        "data_source_inputters": [
                            {
                                "open_id": "od-asd2dasdasd",
                                "user_id": "ou-ux987dsf6x"
                            }
                        ],
                        "metric_dimension_id": "7272581996315099155",
                        "review_rule_config": {
                            "max": "10",
                            "min": "0"
                        }
                    }
                ],
                "groups": [
                    {
                        "group_id": "7296466589195436051",
                        "name": "分组 1"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2MetricTemplatesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}