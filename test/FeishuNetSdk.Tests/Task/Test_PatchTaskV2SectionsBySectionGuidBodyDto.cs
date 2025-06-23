namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新自定义分组 请求体
/// <para>接口ID：7259330038033842204</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/section/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2SectionsBySectionGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "section": {
        "name": "已经审核过的任务",
        "insert_before": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2",
        "insert_after": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2"
    },
    "update_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2SectionsBySectionGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}