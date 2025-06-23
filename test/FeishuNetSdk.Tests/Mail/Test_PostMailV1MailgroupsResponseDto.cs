namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组 响应体
/// <para>接口ID：6954915601882857475</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "mailgroup_id": "xxxxxxxxxxxxxxx",
        "email": "test_mail_group@xxx.xx",
        "name": "test mail group",
        "description": "mail group for testing",
        "direct_members_count": "10",
        "include_external_member": true,
        "include_all_company_member": false,
        "who_can_send_mail": "ALL_INTERNAL_USERS"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MailgroupsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}