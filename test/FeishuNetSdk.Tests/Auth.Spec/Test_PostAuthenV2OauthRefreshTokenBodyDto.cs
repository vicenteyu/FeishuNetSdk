namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 刷新 user_access_token 请求体
/// <para>接口ID：7435312925587898371</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/refresh-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2frefresh-user-access-token</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV2OauthRefreshTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "refresh_token",
    "client_id": "cli_a5ca35a685b0x26e",
    "client_secret": "baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy",
    "refresh_token": "eyJhbGciOiJFUzI1NiIs**********XXOYOZz1mfgIYHwM8ZJA"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthenV2OauthRefreshTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}