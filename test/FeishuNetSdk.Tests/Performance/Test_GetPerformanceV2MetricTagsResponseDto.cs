namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取指标标签列表 响应体
/// <para>接口ID：7397354450872991745</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/metric_template/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_tag%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPerformanceV2MetricTagsResponseDto : TestBase
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
                "tag_id": "7302271694582841364",
                "tag_name": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "index": 100,
                "create_time": "1678870702466",
                "update_time": "1605529625257"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.GetPerformanceV2MetricTagsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}