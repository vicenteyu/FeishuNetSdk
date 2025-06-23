namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 将公共邮箱移至回收站 请求体
/// <para>接口ID：7296319822873673730</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/public-mailbox/public_mailbox/remove_to_recycle_bin</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fremove_to_recycle_bin</para>
/// </summary>
[TestClass]
public class Test_DeleteMailV1PublicMailboxesByPublicMailboxIdRemoveToRecycleBinBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "to_mail_address": "user@xxx.xx"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.DeleteMailV1PublicMailboxesByPublicMailboxIdRemoveToRecycleBinBodyDto>(json);
        Assert.IsNotNull(result);
    }
}