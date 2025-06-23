namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组别名 响应体
/// <para>接口ID：6993201646486536194</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-alias%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdAliasesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "mailgroup_alias": {
            "primary_email": "xxx@xx.xxx",
            "email_alias": "xxx@xx.xxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdAliasesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}