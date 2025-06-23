namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询公共邮箱的所有别名 响应体
/// <para>接口ID：6993201646486487042</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-alias/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-alias%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1PublicMailboxesByPublicMailboxIdAliasesResponseDto : TestBase
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
                "primary_email": "xxx@xx.xxx",
                "email_alias": "xxx@xx.xxx"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1PublicMailboxesByPublicMailboxIdAliasesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}