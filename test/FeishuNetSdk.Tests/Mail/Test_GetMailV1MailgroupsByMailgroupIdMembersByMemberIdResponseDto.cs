namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询指定邮件组成员 响应体
/// <para>接口ID：6954915601882726403</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMailV1MailgroupsByMailgroupIdMembersByMemberIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "member_id": "xxxxxxxxxxxxxxx",
        "email": "test_memeber@xxx.xx",
        "user_id": "xxxxxxxxxx",
        "department_id": "xxxxxxxxxx",
        "type": "USER"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1MailgroupsByMailgroupIdMembersByMemberIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}