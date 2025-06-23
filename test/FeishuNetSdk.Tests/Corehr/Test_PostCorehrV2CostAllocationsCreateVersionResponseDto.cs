namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建成本分摊 响应体
/// <para>接口ID：7486406573931741187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/create_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fcreate_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostAllocationsCreateVersionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "cost_allocation_id": "12345678"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostAllocationsCreateVersionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}