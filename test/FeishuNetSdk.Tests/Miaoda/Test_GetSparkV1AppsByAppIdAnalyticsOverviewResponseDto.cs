// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdAnalyticsOverviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭应用运营数据总览 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭应用运营数据总览 响应体
/// <para>接口ID：7679858182357994438</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/open_api_analytics_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fopen_api_analytics_overview</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdAnalyticsOverviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "active_users": {
            "value": "12500",
            "prev_value": "15000",
            "diff": "-2500",
            "ratio": -0.1667
        },
        "signups": {
            "value": "12500",
            "prev_value": "15000",
            "diff": "-2500",
            "ratio": -0.1667
        },
        "page_views": {
            "value": "12500",
            "prev_value": "15000",
            "diff": "-2500",
            "ratio": -0.1667
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdAnalyticsOverviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}