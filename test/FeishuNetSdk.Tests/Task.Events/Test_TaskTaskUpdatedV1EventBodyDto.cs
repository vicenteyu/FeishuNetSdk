// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_TaskTaskUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 任务信息变更（应用维度） 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task.Events;

/// <summary>
/// 测试 任务信息变更（应用维度） 事件体
/// <para>接口ID：7006161183808552988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_TaskTaskUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "task.task.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "task_id": "626cf808-4c26-4f27-9da8-01f2eb73d717",
        "obj_type": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Task.Events.TaskTaskUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}