// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1PublicMailboxesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询所有公共邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 查询所有公共邮箱 响应体
/// <para>接口ID：6954915601882955779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1PublicMailboxesResponseDto : TestBase
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
                "public_mailbox_id": "xxxxxxxxxxxxxxx",
                "email": "test_public_mailbox@xxx.xx",
                "name": "test public mailbox",
                "geo": "cn"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1PublicMailboxesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}