namespace FeishuNetSdk.Tests.Task.Events;

/// <summary>
/// 测试 任务评论信息变更 事件体
/// <para>接口ID：7006161183808536604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_TaskTaskCommentUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "task.task.comment.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "task_id": "626cf808-4c26-4f27-9da8-01f2eb73d717",
        "comment_id": "6994706512731963411",
        "parent_id": "6994706512731965890",
        "obj_type": 1
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Task.Events.TaskTaskCommentUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}