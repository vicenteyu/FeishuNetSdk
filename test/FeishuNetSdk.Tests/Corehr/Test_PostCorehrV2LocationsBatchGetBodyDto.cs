namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 通过地点 ID 批量获取地点信息 请求体
/// <para>接口ID：7252157701853167644</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2LocationsBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "location_ids": [
        "1215"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2LocationsBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}