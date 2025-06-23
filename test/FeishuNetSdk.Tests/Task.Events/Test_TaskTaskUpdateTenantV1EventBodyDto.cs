namespace FeishuNetSdk.Tests.Task.Events;

/// <summary>
/// 测试 任务信息变更（租户维度） 事件体
/// <para>接口ID：7044355281854087196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/events/update_tenant</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fevents%2fupdate_tenant</para>
/// </summary>
[TestClass]
public class Test_TaskTaskUpdateTenantV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "task.task.update_tenant_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "user_id_list": {
            "user_id_list": [
                {
                    "union_id": "null",
                    "user_id": "null",
                    "open_id": "ou_5df8b925054285f7166bf8b6ff03341f"
                }
            ]
        },
        "task_id": "24314cff-b7fe-438d-a232-b1a80a5f3371",
        "object_type": "task",
        "event_type": "update"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Task.Events.TaskTaskUpdateTenantV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}