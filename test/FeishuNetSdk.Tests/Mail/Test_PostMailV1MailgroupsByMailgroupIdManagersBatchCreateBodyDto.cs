namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建邮件组管理员 请求体
/// <para>接口ID：7172379500607684612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-manager/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-manager%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdManagersBatchCreateBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdManagersBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}