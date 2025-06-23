namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 新增提醒时间 响应体
/// <para>接口ID：6985127383322312706</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-reminder/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-reminder%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdRemindersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reminder": {
            "id": "1",
            "relative_fire_minute": 30
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdRemindersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}