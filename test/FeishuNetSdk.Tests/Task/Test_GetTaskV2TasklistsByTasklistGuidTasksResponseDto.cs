namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取清单任务列表 响应体
/// <para>接口ID：7255580838154698780</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/tasks</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2ftasks</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2TasklistsByTasklistGuidTasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "guid": "e297ddff-06ca-4166-b917-4ce57cd3a7a0",
                "summary": "年终总结",
                "completed_at": "1675742789470",
                "start": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "due": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "members": [
                    {
                        "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                        "type": "user",
                        "role": "assignee"
                    }
                ],
                "subtask_count": 1
            }
        ],
        "page_token": "aWQ9NzEwMjMzMjMxMDE=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2TasklistsByTasklistGuidTasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}