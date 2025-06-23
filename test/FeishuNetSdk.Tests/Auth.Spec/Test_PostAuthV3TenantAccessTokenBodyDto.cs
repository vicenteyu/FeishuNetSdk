namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 商店应用获取 tenant_access_token 请求体
/// <para>接口ID：6995779366223740932</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3TenantAccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_access_token": "a-32bd8551db2f081cbfd26293f27516390b9feb04",
    "tenant_key": "73658811060f175d"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3TenantAccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}