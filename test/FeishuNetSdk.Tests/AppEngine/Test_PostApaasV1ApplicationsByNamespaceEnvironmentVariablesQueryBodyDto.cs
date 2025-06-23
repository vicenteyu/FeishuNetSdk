namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询环境变量列表 请求体
/// <para>接口ID：7385474062586298370</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-environment_variable/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-environment_variable%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceEnvironmentVariablesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter": {
        "quick_query": "Sample Text"
    },
    "limit": 10,
    "offset": 0
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceEnvironmentVariablesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}