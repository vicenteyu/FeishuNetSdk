namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 修改邮件组部分信息 请求体
/// <para>接口ID：6954915601882710019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchMailV1MailgroupsByMailgroupIdBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Mail.PatchMailV1MailgroupsByMailgroupIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}