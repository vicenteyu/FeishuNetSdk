namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 自建应用获取 tenant_access_token 响应体
/// <para>接口ID：6995779366223724548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token_internal</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3TenantAccessTokenInternalResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "tenant_access_token": "t-caecc734c2e3328a62489fe0648c4b98779515d3",
    "expire": 7200
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3TenantAccessTokenInternalResponseDto>(json);
        Assert.IsNotNull(result);
    }
}