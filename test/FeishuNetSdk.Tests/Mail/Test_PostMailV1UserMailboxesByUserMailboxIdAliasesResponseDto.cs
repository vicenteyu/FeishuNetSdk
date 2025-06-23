namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建用户邮箱别名 响应体
/// <para>接口ID：7034854712587763714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-alias/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-alias%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdAliasesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_mailbox_alias": {
            "primary_email": "xxx@xx.xxx",
            "email_alias": "xxx@xx.xxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdAliasesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}