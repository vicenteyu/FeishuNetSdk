namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 获取数据知识分类列表 响应体
/// <para>接口ID：7424752773160812548</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset_tag%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppsByAppIdDataAssetTagsResponseDto : TestBase
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
            {
                "data_asset_tag_id": "spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs",
                "name": "电影"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppsByAppIdDataAssetTagsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}