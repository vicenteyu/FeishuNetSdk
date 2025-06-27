// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2MetricLibsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取指标列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标列表 请求体
/// <para>接口ID：7380276358332661761</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_lib%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2MetricLibsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "is_active": true,
    "tag_ids": [
        "7302271694582841364"
    ],
    "type_ids": [
        "7272578300650717203"
    ],
    "range_of_availability": "admins_and_reviewees",
    "scoring_setting_type": "score_manually"
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2MetricLibsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}