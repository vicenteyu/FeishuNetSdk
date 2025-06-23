namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标模板列表 请求体
/// <para>接口ID：7380276358332710913</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_template%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricTemplatesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "metrics_template_ids": [
        "7360956875099078676"
    ],
    "status": "to_be_configured"
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2MetricTemplatesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}