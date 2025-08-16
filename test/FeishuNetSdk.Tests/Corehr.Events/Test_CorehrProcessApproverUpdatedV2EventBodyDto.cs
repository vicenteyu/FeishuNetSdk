// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrProcessApproverUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批任务状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 审批任务状态变更 事件体
/// <para>接口ID：7296819819722555420</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/updated-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrProcessApproverUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.process.approver.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "process_id": "7072306364927985196",
        "approver_id": "7072306364927985187",
        "type": 1,
        "status": 1,
        "biz_type": "renewal_record",
        "flow_definition_id": "people_7182520625066475540_7222929439175839532",
        "node_definition_id": "approval_7c7d9c4d25b",
        "node_id": "7369419552616089132",
        "node_id_str": "7369419552616089132"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrProcessApproverUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}