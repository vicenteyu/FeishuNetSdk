// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HelpdeskNotificationApproveV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 推送审核通知 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Events;

/// <summary>
/// 测试 推送审核通知 事件体
/// <para>接口ID：6999529163292622850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/events/approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fevents%2fapprove</para>
/// </summary>
[TestClass]
public class Test_HelpdeskNotificationApproveV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "helpdesk.notification.approve_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "notification_id": "6981000586476912660",
        "helpdesk_id": "6969495102523703316",
        "approve_status": "审核状态"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Helpdesk.Events.HelpdeskNotificationApproveV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}