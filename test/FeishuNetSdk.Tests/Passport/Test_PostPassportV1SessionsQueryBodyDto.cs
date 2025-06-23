namespace FeishuNetSdk.Tests.Passport;

/// <summary>
/// 测试 批量获取脱敏的用户登录信息 请求体
/// <para>接口ID：7096084771490578433</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPassportV1SessionsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"user_ids":["7aeddb6a1","7aeddb6a2","7aeddb6a3"]}
""";
        var result = Deserialize<FeishuNetSdk.Passport.PostPassportV1SessionsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}