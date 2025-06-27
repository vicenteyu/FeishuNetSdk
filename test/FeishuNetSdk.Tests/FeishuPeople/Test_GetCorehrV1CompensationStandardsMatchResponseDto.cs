// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1CompensationStandardsMatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取员工薪资标准 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取员工薪资标准 响应体
/// <para>接口ID：7182538601166028802</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/compensation_standard/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompensation_standard%2fmatch</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CompensationStandardsMatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "effective_time": "1660924800000",
        "grade": {
            "currency": {
                "code": "CNY",
                "currency_id": "6863329932261459464",
                "name": {
                    "en_us": "Renminbi (Chinese) yuan",
                    "zh_cn": "人民币元"
                }
            },
            "grade_id": "7174758360888215084",
            "grade_standard_value": {
                "band_width": {
                    "lower_limit": "5000",
                    "upper_limit": "10000"
                },
                "reference_object": {
                    "api_name": "cpst_item",
                    "id": "7156853394442044972"
                },
                "standard_type": {
                    "api_name": "bandwidth_and_standard_value"
                },
                "standard_value": "8888"
            },
            "grade_tid": "7174758360888247852"
        },
        "standard_id": "7174758593538295340"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CompensationStandardsMatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}