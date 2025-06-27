// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出收信规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出收信规则 响应体
/// <para>接口ID：7275929163676073987</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdRulesResponseDto : TestBase
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
                "id": "123124123123",
                "condition": {
                    "match_type": 1,
                    "items": [
                        {
                            "type": 1,
                            "operator": 1,
                            "input": "hello@world.com"
                        }
                    ]
                },
                "action": {
                    "items": [
                        {
                            "type": 1,
                            "input": "283412371233"
                        }
                    ]
                },
                "ignore_the_rest_of_rules": false,
                "name": "将李三的邮件标记为垃圾邮件",
                "is_enable": false
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}