namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量删除公共邮箱成员 请求体
/// <para>接口ID：7187647376462938116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteMailV1PublicMailboxesByPublicMailboxIdMembersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_id_list": [
        "xxxxxxxxxxxxxxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.DeleteMailV1PublicMailboxesByPublicMailboxIdMembersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}