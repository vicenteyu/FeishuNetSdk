namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 流转入职任务 请求体
/// <para>接口ID：7357756972752732162</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/transit_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransit_task</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresByPreHireIdTransitTaskBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "task_id": "1"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresByPreHireIdTransitTaskBodyDto>(json);
        Assert.IsNotNull(result);
    }
}