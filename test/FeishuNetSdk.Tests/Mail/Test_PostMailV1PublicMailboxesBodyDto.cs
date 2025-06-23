namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建公共邮箱 请求体
/// <para>接口ID：6954915601882677251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1PublicMailboxesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "email": "test_public_mailbox@xxx.xx",
    "name": "test public mailbox",
    "geo": "cn"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1PublicMailboxesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}