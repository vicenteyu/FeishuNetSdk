// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ApplicationApplicationFeedbackUpdatedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 反馈更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application.Events;

/// <summary>
/// 测试 反馈更新 事件体
/// <para>接口ID：7072687744306577410</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-feedback%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ApplicationApplicationFeedbackUpdatedV6EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "application.application.feedback.updated_v6",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "feedback_ids": [
            "7057888018203574291"
        ],
        "status": 1,
        "app_id": "cli_9b445f5258795107",
        "update_time": "2021-07-01 17:00:00",
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Application.Events.ApplicationApplicationFeedbackUpdatedV6EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}