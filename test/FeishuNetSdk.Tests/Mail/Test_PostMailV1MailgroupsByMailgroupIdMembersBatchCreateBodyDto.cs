// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1MailgroupsByMailgroupIdMembersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量创建邮件组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量创建邮件组成员 请求体
/// <para>接口ID：7187647376462954500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdMembersBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "items": [
        {
            "user_id": "xxxxxxxxxx",
            "type": "USER"
        },
        {
            "department_id": "xxxxxxxxxx",
            "type": "DEPARTMENT"
        },
        {
            "type": "COMPANY"
        },
        {
            "email": "test_memeber@xxx.xx",
            "type": "MAIL_GROUP"
        },
        {
            "email": "test_memeber@yyy.yy",
            "type": "EXTERNAL_USER"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdMembersBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}