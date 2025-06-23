namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询货币信息 响应体
/// <para>接口ID：7072978200179294210</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/currency/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcurrency%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CurrenciesResponseDto : TestBase
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
                "id": "1",
                "country_region_id": "12",
                "currency_name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "numeric_code": 12,
                "currency_alpha_3_code": "12"
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CurrenciesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}