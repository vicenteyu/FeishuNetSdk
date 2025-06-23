namespace FeishuNetSdk.Tests.Passport;

/// <summary>
/// 测试 退出登录 请求体
/// <para>接口ID：7419242474898472963</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/login-state-management/logout</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2flogout</para>
/// </summary>
[TestClass]
public class Test_PostPassportV1SessionsLogoutBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "idp_credential_id": "user@xxx.xx",
    "logout_type": 1,
    "terminal_type": [
        1
    ],
    "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "logout_reason": 34,
    "sid": "AAAAAAAAAANll6nQoIAAFA=="
}
""";
        var result = Deserialize<FeishuNetSdk.Passport.PostPassportV1SessionsLogoutBodyDto>(json);
        Assert.IsNotNull(result);
    }
}