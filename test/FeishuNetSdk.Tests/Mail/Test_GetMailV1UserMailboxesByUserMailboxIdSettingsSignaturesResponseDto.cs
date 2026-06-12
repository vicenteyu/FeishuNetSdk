// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdSettingsSignaturesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出邮件签名 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 列出邮件签名 响应体
/// <para>接口ID：7629252749259951314</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/get_signatures</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fget_signatures</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdSettingsSignaturesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "signatures": [
            {
                "id": "sig_xxxxxx",
                "name": "我的签名",
                "content": "<div>Best regards</div>",
                "signature_type": "USER",
                "signature_device": "PC",
                "template_json_keys": [
                    "B-NAME"
                ],
                "images": [
                    {
                        "image_name": "logo.png",
                        "file_key": "boxcnxxx",
                        "cid": "image001@01DA1234.5678ABCD",
                        "file_size": "102400",
                        "image_width": 200,
                        "image_height": 100,
                        "download_url": "xxxx"
                    }
                ],
                "user_fields": {
                    "BNAME": "xxxx"
                }
            }
        ],
        "usages": [
            {
                "email_address": "user@example.com",
                "send_mail_signature_id": "sig_xxxxxx",
                "reply_signature_id": "sig_yyyyyy"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdSettingsSignaturesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}