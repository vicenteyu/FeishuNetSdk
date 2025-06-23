namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询归档报表表头 响应体
/// <para>接口ID：7368679915980898306</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/user_stats_fields_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fuser_stats_fields_query</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ArchiveRuleUserStatsFieldsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "archive_report_fields": [
            {
                "code": "1",
                "title": "工号",
                "upper_titles": [
                    "基本信息"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1ArchiveRuleUserStatsFieldsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}