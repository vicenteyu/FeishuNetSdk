namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取项目列表 请求体
/// <para>接口ID：7351374599659765764</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/activity/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2factivity%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ActivityQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_ids": [
        "6992035450862224940"
    ],
    "activity_ids": [
        "6992035450862224940"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2ActivityQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}