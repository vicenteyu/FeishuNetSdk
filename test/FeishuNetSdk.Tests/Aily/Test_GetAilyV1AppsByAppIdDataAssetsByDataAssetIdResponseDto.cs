namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 获取数据知识 响应体
/// <para>接口ID：7441589456115924995</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAilyV1AppsByAppIdDataAssetsByDataAssetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data_asset": {
            "data_asset_id": "asset_aadg3mcgvpybu",
            "label": {
                "zh_ch": "电影评价"
            },
            "description": {
                "zh_ch": "这是一篇关于电影评价的文章"
            },
            "data_source_type": "excel",
            "connect_status": "successful",
            "tags": [
                {
                    "data_asset_tag_id": "spring_5862e4fea8__c__asset_tag_aadg2b5ql4gbs",
                    "name": "电影"
                }
            ],
            "items": [
                {
                    "data_asset_item_id": "asset_item_aadg3mcgvpydu",
                    "api_name": "movie",
                    "label": {
                        "zh_ch": "电影评价"
                    },
                    "description": {
                        "zh_ch": "电影评价信息"
                    },
                    "resources": [
                        {
                            "resource_id": "spring_5862e4fea8__c__dataset_aadg3lxm4j6mg",
                            "resource_type": "dataset"
                        }
                    ]
                }
            ],
            "connect_failed_reason": "连接超时",
            "connect_type": "direct",
            "created_time": "1711975665710",
            "updated_time": "1711975665710"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.GetAilyV1AppsByAppIdDataAssetsByDataAssetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}