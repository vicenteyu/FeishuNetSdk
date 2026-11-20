// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自动回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取自动回复 响应体
/// <para>接口ID：7695747058687036629</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/get_auto_reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fget_auto_reply</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "enabled": true,
        "content_html": "<p>Out of office</p>",
        "content_summary": "Out of office",
        "start_time": "1786723200000",
        "end_time": "1787068799999",
        "time_zone": "28800",
        "only_send_to_tenant": false,
        "last_updated_time": "1786723200000",
        "images": [
            {
                "image_name": "logo.png",
                "file_key": "file_v3_abc",
                "cid": "image001",
                "file_size": "1024"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}