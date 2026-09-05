// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdQueryAnalyticsDataBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭应用运营数据趋势 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭应用运营数据趋势 请求体
/// <para>接口ID：7679858182358010822</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/query_analytics_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fquery_analytics_data</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdQueryAnalyticsDataBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "metric_types": [
        "TOTAL_USER , ACTIVE_USER, NEW_USER, PAGE_VIEW"
    ],
    "start_timestamp_ns": "1782132931498000000",
    "end_timestamp_ns": "1782132931498000000",
    "time_aggregation_unit": "DAY",
    "filter": {
        "page": "/home",
        "device_types": [
            "mobile"
        ]
    },
    "need_pack_lack_point": true,
    "group_by": "device_type"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdQueryAnalyticsDataBodyDto>(json);
        Assert.IsNotNull(result);
    }
}