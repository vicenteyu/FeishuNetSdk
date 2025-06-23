namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取被评估人信息 请求体
/// <para>接口ID：7380276358332678145</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freviewee%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2RevieweesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "semester_id": "6992035450862224940",
    "user_ids": [
        "ou_3245842393d09e9428ad4655da6e30b3"
    ],
    "activity_ids": [
        "7266780609384392723"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2RevieweesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}