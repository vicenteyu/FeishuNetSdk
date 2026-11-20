// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyImagesDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自动回复图片下载链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取自动回复图片下载链接 响应体
/// <para>接口ID：7695747058687003861</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-setting/download_url_auto_reply_image</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-setting%2fdownload_url_auto_reply_image</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyImagesDownloadUrlResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "download_urls": [
            {
                "attachment_id": "YQqYbQHoQoDqXjxWKhJbo8Gicjf",
                "download_url": "https://api-drive-stream.feishu.cn/space/api/box/stream/download/authcode/?code=YTZiZGViMDg3NzRjMzEwOWRkMGI1MTJlYmQxYTFmYTBfZTA5ZjZiOWU4NDYzMzkxMDUyOTIxMzBmNTVjMjAyZTFfSUQ6NzI4MTE4Nzg1OTE5NTc3Mjk0N18xNjk1ODg4NjQyOjE2OTU4ODg3MDJfVjM"
            }
        ],
        "failed_reasons": [
            {
                "attachment_id": "ZQqYbQHoQoDqXjxWKhJbo8Gicjf",
                "reason": "attachment_not_found"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdSettingsAutoReplyImagesDownloadUrlResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}