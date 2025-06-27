// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdAttachmentsDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取附件下载链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取附件下载链接 响应体
/// <para>接口ID：7296319822873657346</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-message/user_mailbox-message-attachment/download_url</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-message-attachment%2fdownload_url</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdAttachmentsDownloadUrlResponseDto : TestBase
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
                "download_url": "https://api-drive-stream.blmpb.com/space/api/box/stream/download/authcode/?code=YTZiZGViMDg3NzRjMzEwOWRkMGI1MTJlYmQxYTFmYTBfZTA5ZjZiOWU4NDYzMzkxMDUyOTIxMzBmNTVjMjAyZTFfSUQ6NzI4MTE4Nzg1OTE5NTc3Mjk0N18xNjk1ODg4NjQyOjE2OTU4ODg3MDJfVjM"
            }
        ],
        "failed_ids": [
            "YQqYbQHoQoDqXjxWKhJbo8Gicjf"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdAttachmentsDownloadUrlResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}