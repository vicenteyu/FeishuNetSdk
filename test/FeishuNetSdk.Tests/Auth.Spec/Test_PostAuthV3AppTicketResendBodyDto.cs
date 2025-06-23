namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 重新获取 app_ticket 请求体
/// <para>接口ID：6995779366223757316</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/app_ticket_resend</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2fapp_ticket_resend</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3AppTicketResendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id": "cli_slkdjalasdkjasd",
    "app_secret": "dskLLdkasdjlasdKK"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3AppTicketResendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}