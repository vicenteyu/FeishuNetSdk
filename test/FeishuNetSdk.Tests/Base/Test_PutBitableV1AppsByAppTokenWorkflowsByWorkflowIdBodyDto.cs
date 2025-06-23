namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新自动化流程状态 请求体
/// <para>接口ID：7447033368182587393</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-workflow/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-workflow%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBitableV1AppsByAppTokenWorkflowsByWorkflowIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": "Enable"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PutBitableV1AppsByAppTokenWorkflowsByWorkflowIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}