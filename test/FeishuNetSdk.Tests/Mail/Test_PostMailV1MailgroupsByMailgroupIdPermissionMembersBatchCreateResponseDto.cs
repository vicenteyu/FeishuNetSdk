namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建邮件组权限成员 响应体
/// <para>接口ID：7187647376462888964</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-permission_member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-permission_member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdPermissionMembersBatchCreateResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdPermissionMembersBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}