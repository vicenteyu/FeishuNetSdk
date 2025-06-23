namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 修改邮件组全部信息 请求体
/// <para>接口ID：6954915601882791939</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutMailV1MailgroupsByMailgroupIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{ 
   "email": "xxx@xxx.com",
    "name": "xxx",
    "description": "xxx",
    "who_can_send_mail": "ANYONE"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PutMailV1MailgroupsByMailgroupIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}