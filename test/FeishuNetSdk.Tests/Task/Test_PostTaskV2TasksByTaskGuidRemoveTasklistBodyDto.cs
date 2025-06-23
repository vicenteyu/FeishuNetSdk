namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 任务移出清单 请求体
/// <para>接口ID：7255580838154780700</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/remove_tasklist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_tasklist</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidRemoveTasklistBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tasklist_guid": "d300a75f-c56a-4be9-80d1-e47653028ceb"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidRemoveTasklistBodyDto>(json);
        Assert.IsNotNull(result);
    }
}