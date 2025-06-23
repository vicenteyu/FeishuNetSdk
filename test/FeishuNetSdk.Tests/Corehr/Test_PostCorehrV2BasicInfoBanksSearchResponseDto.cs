namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询银行信息 响应体
/// <para>接口ID：7301516605753196547</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-bank/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoBanksSearchResponseDto : TestBase
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
                "bank_id": "MDBH00000080",
                "bank_name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "bank_code": "CMB",
                "country_region_id": "6862995757234914824",
                "status": 1,
                "create_time": "2020-01-01 00:00:00",
                "update_time": "2024-01-01 00:00:00"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoBanksSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}