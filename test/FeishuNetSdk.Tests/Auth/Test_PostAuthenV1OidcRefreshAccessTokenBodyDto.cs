namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 刷新 user_access_token 请求体
/// <para>接口ID：7277403063290707996</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/authen/create-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-refresh_access_token%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV1OidcRefreshAccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "refresh_token",
    "refresh_token": "ur-h4_5nUXdJ4O8rqfGe.YJCwM13Gjc557xUG20hkk00f7K"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.PostAuthenV1OidcRefreshAccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}