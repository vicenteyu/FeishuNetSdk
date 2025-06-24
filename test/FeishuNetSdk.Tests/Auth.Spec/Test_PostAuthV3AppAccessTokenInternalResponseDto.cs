namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 自建应用获取 app_access_token 响应体
/// <para>接口ID：6995779366223822852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_access_token_internal</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3AppAccessTokenInternalResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_access_token": "t-g1044ghJRUIJJ5ZPPZMOHKWZISL33E4QSS3abcef",
    "code": 0,
    "expire": 7200,
    "msg": "ok",
    "tenant_access_token": "t-g1044ghJRUIJJ5ZPPZMOHKWZISL33E4QSS3abcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3AppAccessTokenInternalResponseDto>(json);
        Assert.IsNotNull(result);
    }
}