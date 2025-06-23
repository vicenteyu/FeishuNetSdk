namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 搜索消息 响应体
/// <para>接口ID：7208771563588059139</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fmessage%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2MessageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            "om_dc13264520392913993dd051dba21dcf"
        ],
        "page_token": "GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhUPhXQDvtrQ==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.PostSearchV2MessageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}