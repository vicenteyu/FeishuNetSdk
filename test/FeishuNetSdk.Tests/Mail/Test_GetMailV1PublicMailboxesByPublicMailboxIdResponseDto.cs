namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询指定公共邮箱 响应体
/// <para>接口ID：6954915601883119619</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMailV1PublicMailboxesByPublicMailboxIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "public_mailbox_id": "xxxxxxxxxxxxxxx",
        "email": "test_public_mailbox@xxx.xx",
        "name": "test public mailbox",
        "geo": "cn"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1PublicMailboxesByPublicMailboxIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}