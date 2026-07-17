// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-17
//
// Last Modified By : yxr
// Last Modified On : 2026-07-17
// ************************************************************************
// <copyright file="Test_ApprovalInstanceStatusChangedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批实例状态变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Events;

/// <summary>
/// 测试 审批实例状态变更事件 事件体
/// <para>接口ID：7663359183039843593</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fevents%2fstatus_changed</para>
/// </summary>
[TestClass]
public class Test_ApprovalInstanceStatusChangedV4EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "approval.instance.status_changed_v4",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
        "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
        "external_id": "2f719dfd-bbdf-440b-9947-e79665a18c20",
        "status": "APPROVED",
        "operate_time": "1782882600000",
        "start_user": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Approval.Events.ApprovalInstanceStatusChangedV4EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}