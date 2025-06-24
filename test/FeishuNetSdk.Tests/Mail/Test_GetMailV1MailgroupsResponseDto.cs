// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1MailgroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取邮件组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量获取邮件组 响应体
/// <para>接口ID：6954915601882988547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1MailgroupsResponseDto : TestBase
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
                "mailgroup_id": "xxxxxxxxxxxxxxx",
                "email": "test_mail_group@xxx.xx",
                "name": "test mail group",
                "description": "mail group for testing",
                "direct_members_count": "10",
                "include_external_member": true,
                "include_all_company_member": false,
                "who_can_send_mail": "ALL_INTERNAL_USERS"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1MailgroupsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}