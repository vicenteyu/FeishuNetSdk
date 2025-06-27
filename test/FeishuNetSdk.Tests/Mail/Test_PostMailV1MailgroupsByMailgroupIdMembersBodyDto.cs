// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1MailgroupsByMailgroupIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建邮件组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 创建邮件组成员 请求体
/// <para>接口ID：6954915601883037699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MailgroupsByMailgroupIdMembersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "email": "test_memeber@xxx.xx",
    "user_id": "xxxxxxxxxx",
    "department_id": "xxxxxxxxxx",
    "type": "USER"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MailgroupsByMailgroupIdMembersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}