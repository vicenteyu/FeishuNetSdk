namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 任务加入清单 请求体
/// <para>接口ID：7255580838154502172</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_tasklist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_tasklist</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidAddTasklistBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tasklist_guid": "d300a75f-c56a-4be9-80d1-e47653028ceb",
    "section_guid": "d300a75f-c56a-4be9-80d1-e47653028ceb"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidAddTasklistBodyDto>(json);
        Assert.IsNotNull(result);
    }
}