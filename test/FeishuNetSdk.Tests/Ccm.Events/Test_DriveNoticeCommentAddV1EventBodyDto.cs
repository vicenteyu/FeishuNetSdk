// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_DriveNoticeCommentAddV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加评论、回复通知事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Events;

/// <summary>
/// 测试 添加评论、回复通知事件 事件体
/// <para>接口ID：7623827135371250639</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/notice/events/comment_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fnotice%2fevents%2fcomment_add</para>
/// </summary>
[TestClass]
public class Test_DriveNoticeCommentAddV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "drive.notice.comment_add_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "notice_meta": {
            "file_type": "docx",
            "file_token": "TLLKdcpDro9ijQxA33ycNMabcef",
            "from_user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "to_user_id": {
                "union_id": "on_8ed6aa67826108097d9ee143816345",
                "user_id": "e33ggbyz",
                "open_id": "ou_84aad35d084aa403a838cf73ee18467"
            },
            "notice_type": "add_comment"
        },
        "comment_id": "7618859513273112345",
        "reply_id": "7618859513273112345",
        "is_mentioned": true
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Ccm.Events.DriveNoticeCommentAddV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}