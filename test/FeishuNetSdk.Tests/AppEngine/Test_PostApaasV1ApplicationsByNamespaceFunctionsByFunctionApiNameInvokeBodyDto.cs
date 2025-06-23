namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 执行函数 请求体
/// <para>接口ID：7385474062586281986</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-function/invoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-function%2finvoke</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceFunctionsByFunctionApiNameInvokeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "params": "{\"key1\":\"value1\",\"key2\":\"value2\",\"key3\":1718313981794}"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceFunctionsByFunctionApiNameInvokeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}