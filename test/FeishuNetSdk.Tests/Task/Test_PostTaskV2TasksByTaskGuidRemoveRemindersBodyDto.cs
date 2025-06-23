namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 移除任务提醒 请求体
/// <para>接口ID：7255580838154829852</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/remove_reminders</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_reminders</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidRemoveRemindersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reminder_ids": [
        "7202449098622894100"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidRemoveRemindersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}