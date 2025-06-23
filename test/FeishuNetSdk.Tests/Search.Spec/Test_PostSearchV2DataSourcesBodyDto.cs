namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 创建数据源 请求体
/// <para>接口ID：6953505452630212611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2DataSourcesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "客服工单",
    "description": "xxx",
    "icon_url": "yyy",
    "schema_id": "example_schema",
    "template": "",
    "state": 0
}
""";
        var result = Deserialize<FeishuNetSdk.Search.Spec.PostSearchV2DataSourcesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}