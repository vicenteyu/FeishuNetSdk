namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启用/停用自定义组织 请求体
/// <para>接口ID：7358017162446471172</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2factive</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsActiveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "org_id": "6862995757234914823",
    "object_api_name": "custom_org_01",
    "active": true,
    "effective_time": "2020-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsActiveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}