namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 发起流程 请求体
/// <para>接口ID：7442599557486624772</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/application-flow/execute</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-flow%2fexecute</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator": "{\"_id\": 1111, \"email\": \"apaas@bytedance.com\"}",
    "params": "{\"variable_rgrtgqworiginal\": {\"_id\": 5454545}}",
    "is_async": true
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceFlowsByFlowIdExecuteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}