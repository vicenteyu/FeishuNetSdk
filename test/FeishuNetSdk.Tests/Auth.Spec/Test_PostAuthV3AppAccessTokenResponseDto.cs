namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 商店应用获取 app_access_token 响应体
/// <para>接口ID：6995779366223708164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_access_token</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3AppAccessTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "app_access_token": "a-6U1SbDiM6XIH2DcTCPyeub",
    "expire": 7140
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Auth.Spec.PostAuthV3AppAccessTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}