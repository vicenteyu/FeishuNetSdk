namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 修改数据源 响应体
/// <para>接口ID：6953505452630179843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSearchV2DataSourcesByDataSourceIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.Spec.PatchSearchV2DataSourcesByDataSourceIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}