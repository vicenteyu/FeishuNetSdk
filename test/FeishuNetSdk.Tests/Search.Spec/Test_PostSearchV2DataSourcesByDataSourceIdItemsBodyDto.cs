namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 为指定数据项创建索引 请求体
/// <para>接口ID：6953505452630163459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source-item/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source-item%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2DataSourcesByDataSourceIdItemsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id": "my_item_01010111",
    "acl": [
        {
            "access": "allow",
            "value": "everyone",
            "type": "user"
        }
    ],
    "metadata": {
        "title": "工单：无法创建文章",
        "source_url": "http://www.abc.com.cn",
        "create_time": 1618831236,
        "update_time": 1618831236
    },
    "structured_data": "{\"description\":\"问题出现的环境和复现方法描述……\", \"priority\":\"HIGH\"}",
    "content": {
        "format": "html",
        "content_data": "这是一个很长的文本"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Search.Spec.PostSearchV2DataSourcesByDataSourceIdItemsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}