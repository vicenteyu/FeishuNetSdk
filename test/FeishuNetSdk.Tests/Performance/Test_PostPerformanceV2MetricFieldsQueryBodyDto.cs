// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricFieldsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取指标字段列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标字段列表 请求体
/// <para>接口ID：7380276358332727297</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_field%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricFieldsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "field_ids": [
        "7293169069640630291"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2MetricFieldsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}