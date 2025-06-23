namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 创建或修改临时排班 请求体
/// <para>接口ID：7446612629576892419</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/user_daily_shift/batch_create_temp</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create_temp</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserDailyShiftsBatchCreateTempBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_tmp_daily_shifts": [
        {
            "group_id": "6737202939523236110",
            "user_id": "abd754f7",
            "date": 20240120,
            "shift_name": "临时早班",
            "punch_time_simple_rules": [
                {
                    "on_time": "9：00",
                    "off_time": "18：00"
                }
            ]
        }
    ],
    "operator_id": "dd31248a"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserDailyShiftsBatchCreateTempBodyDto>(json);
        Assert.IsNotNull(result);
    }
}