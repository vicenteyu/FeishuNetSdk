namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 商店应用获取 app_access_token 请求体
/// <para>接口ID：6995779366223708164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_access_token</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_access_token</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3AppAccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id": "cli_slkdjalasdkjasd",
    "app_secret": "dskLLdkasdjlasdKK",
    "app_ticket": "dskLLdkasd"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3AppAccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}