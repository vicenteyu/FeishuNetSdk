namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 刷新 user_access_token 响应体
/// <para>接口ID：7277403063290707996</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/authen/create-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-refresh_access_token%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV1OidcRefreshAccessTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "access_token": "u-5Dak9ZAxJ9tFUn8MaTD_BFM51FNdg5xzO0y010000HWb",
        "refresh_token": "ur-6EyFQZyplb9URrOx5NtT_HM53zrJg59HXwy040400G.e",
        "token_type": "Bearer",
        "expires_in": 7199,
        "refresh_expires_in": 2591999,
        "scope": "auth:user.id:read bitable:app"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Auth.PostAuthenV1OidcRefreshAccessTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}