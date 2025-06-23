namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 删除成本分摊 请求体
/// <para>接口ID：7486406573931724803</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/remove_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fremove_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostAllocationsRemoveVersionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "7862995757234914824",
    "cost_allocation": {
        "wk_id": "703912325303191204"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CostAllocationsRemoveVersionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}