namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询统计表头 请求体
/// <para>接口ID：7044467124773814273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_field%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserStatsFieldsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "locale": "zh",
    "stats_type": "daily",
    "start_date": 20210316,
    "end_date": 20210323
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserStatsFieldsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}