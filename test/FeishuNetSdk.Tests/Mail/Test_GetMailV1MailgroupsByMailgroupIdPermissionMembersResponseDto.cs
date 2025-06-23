namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量获取邮件组权限成员 响应体
/// <para>接口ID：6954915601882808323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto : TestBase
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
                "permission_member_id": "xxxxxxxxxxxxxxx",
                "user_id": "xxxxxxxxxx",
                "department_id": "xxxxxxxxxx",
                "email": "xxx@xx.x",
                "type": "USER"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1MailgroupsByMailgroupIdPermissionMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}