// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdQueryAnalyticsDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭应用运营数据趋势 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭应用运营数据趋势 响应体
/// <para>接口ID：7679858182358010822</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/query_analytics_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fquery_analytics_data</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdQueryAnalyticsDataResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "series": [
            {
                "metric_type": "TOTAL_USER",
                "points": [
                    {
                        "timestamp_ns": "1782132931498000000",
                        "value": 1,
                        "dimensions": [
                            {
                                "key": "foo",
                                "value": "bar"
                            }
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdQueryAnalyticsDataResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}