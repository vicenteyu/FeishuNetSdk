namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取被评估人信息 响应体
/// <para>接口ID：7380276358332678145</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freviewee%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2RevieweesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "semester_id": "7291278856547794964",
        "reviewees": [
            {
                "reviewee_user_id": {
                    "open_id": "od-asd2dasdasd",
                    "user_id": "ou-ux987dsf6x"
                },
                "activity_ids": [
                    "7376847302857555971"
                ],
                "reviewprofile_url": "https://perf.feishu.cn/perf/profile?rootReviewId=7380183500051202067"
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2RevieweesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}