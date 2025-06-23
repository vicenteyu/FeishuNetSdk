namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 删除默认成本中心 请求体
/// <para>接口ID：7486406573931659267</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/remove_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fremove_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DefaultCostCentersRemoveVersionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "6862995757234914821",
    "default_cost_center": {
        "wk_id": "703912325303191204",
        "wk_tid": "703912321231239801"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DefaultCostCentersRemoveVersionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}