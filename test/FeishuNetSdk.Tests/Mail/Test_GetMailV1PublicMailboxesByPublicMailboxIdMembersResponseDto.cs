// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询所有公共邮箱成员信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询所有公共邮箱成员信息 响应体
/// <para>接口ID：6954915601883004931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto : TestBase
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
                "user_id": "xxxxxxxxxx",
                "type": "USER"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1PublicMailboxesByPublicMailboxIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}