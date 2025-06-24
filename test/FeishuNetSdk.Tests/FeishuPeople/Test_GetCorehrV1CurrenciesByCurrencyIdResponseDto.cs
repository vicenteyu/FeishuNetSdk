// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1CurrenciesByCurrencyIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询单个货币信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个货币信息 响应体
/// <para>接口ID：7072978068286357532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/currency/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcurrency%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CurrenciesByCurrencyIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "currency": {
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CurrenciesByCurrencyIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}