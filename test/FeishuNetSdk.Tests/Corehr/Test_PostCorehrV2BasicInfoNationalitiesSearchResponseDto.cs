namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询国籍信息 响应体
/// <para>接口ID：7301516605753180163</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-nationality/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-nationality%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoNationalitiesSearchResponseDto : TestBase
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
                "nationality_id": "7075702736045475372",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "alpha_2_code": "CN",
                "alpha_3_code": "CHN",
                "numeric_code": 156,
                "country_region_id": "6862995757234914824",
                "status": 1
            }
        ],
        "page_token": "7075702743846897196",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoNationalitiesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}