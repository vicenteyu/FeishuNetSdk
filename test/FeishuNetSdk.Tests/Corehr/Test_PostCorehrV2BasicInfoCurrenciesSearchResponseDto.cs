// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2BasicInfoCurrenciesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询货币信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询货币信息 响应体
/// <para>接口ID：7301516605753163779</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/currency/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-currency%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCurrenciesSearchResponseDto : TestBase
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
                "currency_id": "6863329932261459464",
                "country_region_id_list": [
                    "6862995757234914824"
                ],
                "currency_name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "numeric_code": 156,
                "currency_alpha_3_code": "CNY",
                "status": 1
            }
        ],
        "page_token": "6863329958782043655",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCurrenciesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}