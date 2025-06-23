namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询统计数据 请求体
/// <para>接口ID：7044467124773568513</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/query-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_data%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserStatsDatasQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "locale": "zh",
    "stats_type": "month",
    "start_date": 20210316,
    "end_date": 20210323,
    "user_ids": [
        "ec8ddg56",
        "af5ddg73"
    ],
    "need_history": true,
    "current_group_only": true,
    "user_id": "ec8ddg56"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserStatsDatasQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}