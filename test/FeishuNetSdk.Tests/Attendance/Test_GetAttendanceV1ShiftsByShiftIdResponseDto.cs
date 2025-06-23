namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 按 ID 查询班次 响应体
/// <para>接口ID：7044467124773486593</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/shift/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fshift%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1ShiftsByShiftIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "shift_id": "6919358778597097404",
        "shift_name": "早班",
        "punch_times": 1,
        "sub_shift_leader_ids": [
            "dd31248a"
        ],
        "is_flexible": false,
        "flexible_minutes": 60,
        "flexible_rule": [
            {
                "flexible_early_minutes": 60,
                "flexible_late_minutes": 60
            }
        ],
        "no_need_off": true,
        "punch_time_rule": [
            {
                "on_time": "9:00",
                "off_time": "18:00， 第二天凌晨2点， 26:00",
                "late_minutes_as_late": 30,
                "late_minutes_as_lack": 60,
                "on_advance_minutes": 60,
                "early_minutes_as_early": 30,
                "early_minutes_as_lack": 60,
                "off_delay_minutes": 60,
                "late_minutes_as_serious_late": 40
            }
        ],
        "late_off_late_on_rule": [
            {
                "late_off_minutes": 60,
                "late_on_minutes": 30
            }
        ],
        "rest_time_rule": [
            {
                "rest_begin_time": "13:00",
                "rest_end_time": "14:00"
            }
        ],
        "overtime_rule": [
            {
                "on_overtime": "9:00",
                "off_overtime": "18:00"
            }
        ],
        "allow_punch_approval": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1ShiftsByShiftIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}