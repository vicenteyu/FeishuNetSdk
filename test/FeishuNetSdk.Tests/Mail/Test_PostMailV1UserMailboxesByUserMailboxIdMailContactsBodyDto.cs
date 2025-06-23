namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮箱联系人 请求体
/// <para>接口ID：7270360193791868929</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-mail_contact/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-mail_contact%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdMailContactsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "张三",
    "company": "张三科技有限公司",
    "phone": "19912341234",
    "mail_address": "zhangsan@example.com",
    "tag": "朋友",
    "remark": "飞书发布会认识",
    "position": "CEO"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdMailContactsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}