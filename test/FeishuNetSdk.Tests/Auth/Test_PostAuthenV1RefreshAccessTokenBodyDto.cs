namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 刷新 user_access_token（v1 版本） 请求体
/// <para>接口ID：7180265937329520644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2frefresh_access_token%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV1RefreshAccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "refresh_token",
    "refresh_token": "ur-oQ0mMq6MCcueAv0pwx2fQQhxqv__CbLu6G8ySFwafeKww2Def2BJdOkW3.9gCFM.LBQgFri901QaqeuL"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.PostAuthenV1RefreshAccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}