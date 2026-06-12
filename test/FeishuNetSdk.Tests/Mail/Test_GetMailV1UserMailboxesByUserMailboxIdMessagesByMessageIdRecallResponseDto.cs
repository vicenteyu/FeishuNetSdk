// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取邮件撤回进度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 获取邮件撤回进度 响应体
/// <para>接口ID：7629252749259918546</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-sent_message/get_recall_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-sent_message%2fget_recall_detail</para>
/// </summary>
[TestClass]
public class Test_GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,"msg":"success","data":{"recall_status":"done","recall_result":"all_success","success_count":3,"failure_count":0,"processing_count":0,"items":[{"recipient_address":"zhangsan@example.com","recipient_name":"张三","status":"success","is_mailing_list":false}]}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mail.GetMailV1UserMailboxesByUserMailboxIdMessagesByMessageIdRecallResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}