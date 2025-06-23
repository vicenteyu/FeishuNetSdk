namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询国家/地区信息 响应体
/// <para>接口ID：7301516605753229315</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCountryRegionsSearchResponseDto : TestBase
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
                "country_region_id": "6862995757234914824",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中国"
                    }
                ],
                "full_name": [
                    {
                        "lang": "zh-CN",
                        "value": "中华人民共和国"
                    }
                ],
                "alpha_2_code": "CN",
                "alpha_3_code": "CHN",
                "global_code": "+86",
                "status": 1
            }
        ],
        "page_token": "6862995772275688974",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCountryRegionsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}