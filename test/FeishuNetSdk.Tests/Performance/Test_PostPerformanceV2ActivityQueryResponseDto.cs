namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取项目列表 响应体
/// <para>接口ID：7351374599659765764</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/activity/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2factivity%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ActivityQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "activities": [
            {
                "id": "7343513161666707459",
                "name": {
                    "zh_cn": "项目一",
                    "en_us": "Activity 1"
                },
                "description": {
                    "zh_cn": "体验",
                    "en_us": "Interactive experience"
                },
                "semester_id": "7343513161666707459",
                "mode": "performance_review",
                "progress": "configurable",
                "create_time": "1691951256000",
                "modify_time": "1691951256000",
                "create_user_id": "6924187793321444877",
                "modify_user_id": "6924187793321444877"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV2ActivityQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}