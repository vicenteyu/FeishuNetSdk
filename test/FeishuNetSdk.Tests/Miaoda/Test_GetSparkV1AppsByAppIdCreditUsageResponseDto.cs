// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdCreditUsageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭应用消耗 AI 额度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭应用消耗 AI 额度 响应体
/// <para>接口ID：7679858182357978054</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/open_api_credit_usage</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fopen_api_credit_usage</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdCreditUsageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "total": 1250.5,
        "points": [
            {
                "timestamp": "1690848000",
                "credit_usage": 1250.5,
                "credit_usage_enterprise": 820.3,
                "credit_usage_personal": 430.2
            }
        ],
        "total_enterprise": 980.2,
        "total_personal": 270.3
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdCreditUsageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}