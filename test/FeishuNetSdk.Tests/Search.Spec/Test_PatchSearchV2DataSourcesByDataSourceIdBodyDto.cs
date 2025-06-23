namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 修改数据源 请求体
/// <para>接口ID：6953505452630179843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSearchV2DataSourcesByDataSourceIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "客服工单",
    "state": 0,
    "description": "搜索客服工单",
    "icon_url": "https://www.xxx.com/open.jpg"
}
""";
        var result = Deserialize<FeishuNetSdk.Search.Spec.PatchSearchV2DataSourcesByDataSourceIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}