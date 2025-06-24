// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出邮箱联系人 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出邮箱联系人 响应体
/// <para>接口ID：7270360193791918081</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-mail_contact/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-mail_contact%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto : TestBase
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
                "id": "7256274576546463764",
                "name": "张三",
                "company": "张三科技有限公司",
                "phone": "19912341234",
                "mail_address": "zhangsan@example.com",
                "tag": "朋友",
                "remark": "飞书发布会认识",
                "avatar": "https://exampeimg.com/xxxx.jpg",
                "position": "CEO"
            }
        ],
        "page_token": "xxx",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMailContactsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}