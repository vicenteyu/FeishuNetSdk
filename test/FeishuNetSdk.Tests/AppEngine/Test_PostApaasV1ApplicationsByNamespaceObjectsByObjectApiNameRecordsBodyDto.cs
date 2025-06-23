namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 新建记录 请求体
/// <para>接口ID：7384730094872952860</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record": "{\"book_name\":\"test\"}"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}