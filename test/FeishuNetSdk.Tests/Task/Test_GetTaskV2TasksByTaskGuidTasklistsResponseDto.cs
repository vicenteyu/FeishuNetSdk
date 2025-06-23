namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 列取任务所在清单 响应体
/// <para>接口ID：7255580838154453020</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/tasklists</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2ftasklists</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2TasksByTaskGuidTasklistsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tasklists": [
            {
                "tasklist_guid": "cc371766-6584-cf50-a222-c22cd9055004",
                "section_guid": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2TasksByTaskGuidTasklistsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}