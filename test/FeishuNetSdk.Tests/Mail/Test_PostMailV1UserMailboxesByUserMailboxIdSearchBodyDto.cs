// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostMailV1UserMailboxesByUserMailboxIdSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索邮件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 搜索邮件 请求体
/// <para>接口ID：7648865505080429801</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMailV1UserMailboxesByUserMailboxIdSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "合同审批通知",
    "filter": {
        "from": [
            "zhangsan"
        ],
        "to": [
            "lisi"
        ],
        "cc": [
            "wangwu"
        ],
        "bcc": [
            "yiming"
        ],
        "subject": "合同签署",
        "folder": [
            "trash"
        ],
        "label": [
            "自定义标签"
        ],
        "has_attachment": true,
        "is_unread": true,
        "create_time": {
            "start_time": "2026-03-10T00:00:00+08:00",
            "end_time": "2026-03-10T00:00:00+08:00"
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1UserMailboxesByUserMailboxIdSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}