namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 添加默认成本中心 响应体
/// <para>接口ID：7486406573931675651</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/create_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fcreate_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DefaultCostCentersCreateVersionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "wk_id": "6862995757234914824",
        "wk_tid": "6862995757234914821"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2DefaultCostCentersCreateVersionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}