namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 更新统计设置 请求体
/// <para>接口ID：7044467124773650433</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_stats_data/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_stats_view%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutAttendanceV1UserStatsViewsByUserStatsViewIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "view": {
        "items": [
            {
                "child_items": [
                    {
                        "code": "50102",
                        "value": "0"
                    },
                    {
                        "code": "50111",
                        "value": "0"
                    },
                    {
                        "code": "50104",
                        "value": "0"
                    }
                ],
                "code": "501"
            }
        ],
        "stats_type": "month",
        "user_id": "ec8ddg56",
        "view_id": "TmpnNU5EQXpPVGN3TmpVMU16Y3lPVEEwTXl0dGIyNTBhQT09"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PutAttendanceV1UserStatsViewsByUserStatsViewIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}