namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建邮件组成员 响应体
/// <para>接口ID：7187647376462954500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdMembersBatchCreateResponseDto : TestBase
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
                "email": "test_memeber@xxx.xx",
                "user_id": "xxxxxxxxxx",
                "department_id": "xxxxxxxxxx",
                "type": "USER"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdMembersBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}