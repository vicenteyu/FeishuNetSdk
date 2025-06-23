namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 获取 user_access_token（v1 版本） 请求体
/// <para>接口ID：7180265937329553412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2faccess_token%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV1AccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "authorization_code",
    "code": "xMSldislSkdK"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.PostAuthenV1AccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}