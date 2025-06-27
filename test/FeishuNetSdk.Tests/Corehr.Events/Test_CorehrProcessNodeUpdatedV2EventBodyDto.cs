// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrProcessNodeUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 流程节点状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 流程节点状态变更 事件体
/// <para>接口ID：7340625370520780803</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/updated-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-node%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrProcessNodeUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.process.node.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "flow_definition_id": "people_7182520625066475540_7222929439175839532",
        "node_definition_id": "approval_7c7d9c4d25b",
        "process_id": "7312658016791168538",
        "process_node_id": "7311696871833994796",
        "node_type": 1,
        "node_status": 1,
        "biz_type": "renewal_record"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrProcessNodeUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}