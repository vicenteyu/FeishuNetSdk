namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 录入被评估人关键指标数据 响应体
/// <para>接口ID：7380276358332694529</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fimport</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricDetailsImportResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "import_record_id": "7241404194141224979"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2MetricDetailsImportResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}