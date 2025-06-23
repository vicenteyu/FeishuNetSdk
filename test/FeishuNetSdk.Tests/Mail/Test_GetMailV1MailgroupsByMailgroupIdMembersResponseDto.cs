namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取所有邮件组成员 响应体
/// <para>接口ID：6954915601882972163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1MailgroupsByMailgroupIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "xxx",
        "items": [
            {
                "member_id": "xxxxxxxxxxxxxxx",
                "email": "test_memeber@xxx.xx",
                "user_id": "xxxxxxxxxx",
                "department_id": "xxxxxxxxxx",
                "type": "USER"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1MailgroupsByMailgroupIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}