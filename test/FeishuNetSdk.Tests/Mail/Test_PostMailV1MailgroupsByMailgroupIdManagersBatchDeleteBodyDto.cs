namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量删除邮件组管理员 请求体
/// <para>接口ID：7172379500607700996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-manager/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-manager%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdManagersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "mailgroup_manager_list": [
        {
            "user_id": "xxxxxx"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdManagersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}