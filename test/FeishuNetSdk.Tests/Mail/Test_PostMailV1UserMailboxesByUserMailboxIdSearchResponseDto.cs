// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索邮件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 搜索邮件 响应体
/// <para>接口ID：7648865505080429801</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto : TestBase
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
                "id": "msg_XXX",
                "display_info": "{}",
                "meta_data": {
                    "title": "测试邮件",
                    "thread_id": "thread_id_XXX",
                    "create_time": "2026-03-15T14:30:00+08:00",
                    "message_biz_id": "msg_id_xxx",
                    "from": {
                        "mail_address": "mike@outlook.com",
                        "name": "Mike"
                    }
                }
            }
        ],
        "total": 99,
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "notice": "The query is too long and has been truncated to the first 50 characters for search."
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}