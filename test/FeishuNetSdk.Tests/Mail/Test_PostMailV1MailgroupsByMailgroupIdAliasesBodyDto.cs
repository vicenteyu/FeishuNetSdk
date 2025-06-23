namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组别名 请求体
/// <para>接口ID：6993201646486536194</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-alias%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdAliasesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "email_alias": "xxx@xx.xxx"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdAliasesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}