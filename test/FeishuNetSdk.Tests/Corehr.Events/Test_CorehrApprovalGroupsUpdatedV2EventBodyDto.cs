// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrApprovalGroupsUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 组织架构调整状态变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 组织架构调整状态变更事件 事件体
/// <para>接口ID：7317581509003804676</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrApprovalGroupsUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.approval_groups.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "approval_group_id": "6991776076699549697",
        "process_id": "6991776076699549697",
        "approval_group_status": 1,
        "topic": "测试组织架构调整",
        "adjust_reason": "测试",
        "effective_date": "2022-03-01",
        "created_by": "6974641477444060708",
        "draft_id": "6991776076699549697",
        "draft_status": 1,
        "approval_group_status_v2": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrApprovalGroupsUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}