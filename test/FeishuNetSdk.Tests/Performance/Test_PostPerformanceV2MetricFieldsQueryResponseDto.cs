// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取指标字段列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标字段列表 响应体
/// <para>接口ID：7380276358332727297</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_field%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricFieldsQueryResponseDto : TestBase
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
                "field_id": "7272581996315099155",
                "name": {
                    "zh_cn": "销量",
                    "en_us": "Sales"
                },
                "type": "text"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2MetricFieldsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}