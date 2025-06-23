namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 流转入职任务 响应体
/// <para>接口ID：7357756972752732162</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/transit_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransit_task</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresByPreHireIdTransitTaskResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "success": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PreHiresByPreHireIdTransitTaskResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}