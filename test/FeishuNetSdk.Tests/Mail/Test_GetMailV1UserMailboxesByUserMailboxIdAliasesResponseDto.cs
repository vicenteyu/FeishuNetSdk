// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdAliasesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取用户邮箱所有别名 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取用户邮箱所有别名 响应体
/// <para>接口ID：7034854712587780098</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user_mailbox-alias/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-alias%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdAliasesResponseDto : TestBase
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
                "primary_email": "xxx@xx.xxx",
                "email_alias": "xxx@xx.xxx"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdAliasesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}