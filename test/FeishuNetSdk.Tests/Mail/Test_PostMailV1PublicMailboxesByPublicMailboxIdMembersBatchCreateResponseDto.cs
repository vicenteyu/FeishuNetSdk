namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量添加公共邮箱成员 响应体
/// <para>接口ID：7187647376462921732</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1PublicMailboxesByPublicMailboxIdMembersBatchCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "member_id": "xxxxxxxxxxxxxxx",
                "user_id": "xxxxxxxxxx",
                "type": "USER"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1PublicMailboxesByPublicMailboxIdMembersBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}