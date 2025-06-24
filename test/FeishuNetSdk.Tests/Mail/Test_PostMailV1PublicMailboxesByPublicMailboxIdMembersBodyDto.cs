// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMailV1PublicMailboxesByPublicMailboxIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加公共邮箱成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 添加公共邮箱成员 请求体
/// <para>接口ID：6954915601883103235</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostMailV1PublicMailboxesByPublicMailboxIdMembersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "xxxxxxxxxx",
    "type": "USER"
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1PublicMailboxesByPublicMailboxIdMembersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}