namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取被评估人关键指标结果 请求体
/// <para>接口ID：7380276358332743681</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricDetailsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_id": "6992035450862224940",
    "reviewee_user_ids": [
        "ou_3245842393d09e9428ad4655da6e30b3"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2MetricDetailsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}