// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PayrollPaymentActivityStatusChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发薪活动变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Payroll.Events;

/// <summary>
/// 测试 发薪活动变更 事件体
/// <para>接口ID：7441890276475158531</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2fevents%2fstatus_changed</para>
/// </summary>
[TestClass]
public class Test_PayrollPaymentActivityStatusChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "payroll.payment_activity.status_changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "activity_id": "7433255159377444875",
        "status": 2
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Payroll.Events.PayrollPaymentActivityStatusChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}