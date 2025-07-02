// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricDetailsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取被评估人关键指标结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取被评估人关键指标结果 响应体
/// <para>接口ID：7380276358332743681</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricDetailsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "semester_id": "7291278856547794964",
        "reviewee_metrics": [
            {
                "reviewee_user_id": {
                    "open_id": "od-asd2dasdasd",
                    "user_id": "ou-ux987dsf6x"
                },
                "metric_template_id": "7294570803306168339",
                "metric_details": {
                    "metric_id": "7272581996315099155",
                    "name": "示例指标",
                    "fields": [
                        {
                            "field_id": "7296082067266207764",
                            "field_value": "90",
                            "field_value_person": {
                                "open_id": "od-asd2dasdasd",
                                "user_id": "ou-ux987dsf6x"
                            }
                        }
                    ],
                    "dimension_id": "7303895818346430484",
                    "dimension_name": {
                        "zh_cn": "维度一",
                        "en_us": "Dimension 1"
                    },
                    "dimension_weight": "90%",
                    "add_from": "admin",
                    "is_from_library": true
                },
                "reviewee_stage_statuses": [
                    {
                        "stage_id": "1",
                        "stage_type": "kpi_metric_setting",
                        "stage_status": 0
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2MetricDetailsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}