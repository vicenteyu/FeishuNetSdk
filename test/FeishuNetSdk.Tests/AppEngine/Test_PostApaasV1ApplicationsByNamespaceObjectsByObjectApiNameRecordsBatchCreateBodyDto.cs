namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量新建记录 请求体
/// <para>接口ID：7384730094872985628</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": "[{\"book_name\":\"name21\",\"book_count\":2}]"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}