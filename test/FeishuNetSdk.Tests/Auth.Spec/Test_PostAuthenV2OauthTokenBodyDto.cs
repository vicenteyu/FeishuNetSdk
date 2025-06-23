namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 获取 user_access_token 请求体
/// <para>接口ID：7435312925587914755</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/get-user-access-token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2fget-user-access-token</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV2OauthTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "authorization_code",
    "client_id": "cli_a5ca35a685b0x26e",
    "client_secret": "baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy",
    "code": "a61hb967bd094dge949h79bbexd16dfe",
    "redirect_uri": "https://example.com/api/oauth/callback",
    "code_verifier": "TxYmzM4PHLBlqm5NtnCmwxMH8mFlRWl_ipie3O0aVzo"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthenV2OauthTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}