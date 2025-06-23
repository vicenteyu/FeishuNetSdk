namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索成本中心信息 响应体
/// <para>接口ID：7225452763517075459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersSearchResponseDto : TestBase
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
                "cost_center_id": "6969828847121885087",
                "version_id": "6969828847121885087",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "code": "MDPD00000023",
                "parent_cost_center_id": "6862995757234914824",
                "managers": [
                    "6862995757234914824"
                ],
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "effective_time": "2020-01-01",
                "expiration_time": "2020-01-01",
                "active": true
            }
        ],
        "page_token": "6969828847121885087",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostCentersSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}