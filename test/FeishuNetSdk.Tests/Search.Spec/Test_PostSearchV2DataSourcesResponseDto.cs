namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 创建数据源 响应体
/// <para>接口ID：6953505452630212611</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2DataSourcesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data_source": {
            "id": 6953903108179099667,
            "name": "客服工单",
            "description": "xxx",
            "icon_url": "yyy",
            "template": "",
            "state": 0,
            "is_exceed_quota": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.Spec.PostSearchV2DataSourcesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}