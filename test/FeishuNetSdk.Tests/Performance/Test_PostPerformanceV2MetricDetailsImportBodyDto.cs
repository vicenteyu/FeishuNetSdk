// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricDetailsImportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 录入被评估人关键指标数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 录入被评估人关键指标数据 请求体
/// <para>接口ID：7380276358332694529</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fimport</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricDetailsImportBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_id": "7293040702907514899",
    "import_record_name": "API录入",
    "imported_metrics": [
        {
            "reviewee_user_id": "ou_3245842393d09e9428ad4655da6e30b3",
            "metric_id": "7272580325522276372",
            "fields": [
                {
                    "field_id": "7283776005142675476",
                    "field_value": "100",
                    "field_value_person": "ou_3245842393d09e9428ad4655da6e30b3"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2MetricDetailsImportBodyDto>(json);
        Assert.IsNotNull(result);
    }
}