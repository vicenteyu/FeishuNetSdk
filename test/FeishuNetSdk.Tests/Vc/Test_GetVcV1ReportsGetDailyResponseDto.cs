namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取会议报告 响应体
/// <para>接口ID：6921909217674821659</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/report/get_daily</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freport%2fget_daily</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReportsGetDailyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "meeting_report": {
            "total_meeting_count": "100",
            "total_meeting_duration": "300000",
            "total_participant_count": "20000",
            "daily_report": [
                {
                    "date": "1609113600",
                    "meeting_count": "100",
                    "meeting_duration": "147680",
                    "participant_count": "2000"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReportsGetDailyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}