namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询区/县信息 响应体
/// <para>接口ID：7301516605753147395</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-district%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoDistrictsSearchResponseDto : TestBase
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
                "district_id": "6863333353496512007",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "city_id": "6863333352603125255",
                "subregion_code": "230110",
                "status": 1
            }
        ],
        "page_token": "6863333354096297480",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoDistrictsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}