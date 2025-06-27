// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteMailV1MailgroupsByMailgroupIdMembersBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除邮件组成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 批量删除邮件组成员 请求体
/// <para>接口ID：7187647376462872580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteMailV1MailgroupsByMailgroupIdMembersBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_id_list": [
        "xxxxxxxxxxxxxxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.DeleteMailV1MailgroupsByMailgroupIdMembersBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}