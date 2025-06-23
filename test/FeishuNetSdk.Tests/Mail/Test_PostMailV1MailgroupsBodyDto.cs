namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组 请求体
/// <para>接口ID：6954915601882857475</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "email": "test_mail_group@xxx.xx",
    "name": "test mail group",
    "description": "mail group for testing",
    "who_can_send_mail": "ALL_INTERNAL_USERS"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}