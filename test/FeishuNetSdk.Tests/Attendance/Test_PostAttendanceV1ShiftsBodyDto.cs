// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1ShiftsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建班次 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 创建班次 请求体
/// <para>接口ID：7044467124773601281</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/shift/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fshift%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ShiftsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "shift_name": "早班",
    "punch_times": 1,
    "sub_shift_leader_ids": [
        "456123"
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
            "off_time": "18:00",
            "late_minutes_as_late": 30,
            "late_minutes_as_lack": 60,
            "on_advance_minutes": 60,
            "early_minutes_as_early": 30,
            "early_minutes_as_lack": 60,
            "off_delay_minutes": 60,
            "late_minutes_as_serious_late": 40,
            "no_need_on": true,
            "no_need_off": true
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
    "day_type": 1,
    "overtime_rest_time_rule": [
        {
            "rest_begin_time": "13:00",
            "rest_end_time": "14:00"
        }
    ],
    "late_minutes_as_serious_late": 40,
    "shift_middle_time_rule": {
        "middle_time_type": 0,
        "fixed_middle_time": "12:00"
    },
    "shift_attendance_time_config": {
        "attendance_time": 1,
        "on_attendance_time": 1,
        "off_attendance_time": 1
    },
    "late_off_late_on_setting": {
        "late_off_base_on_time_type": 0,
        "late_on_base_on_time_type": 0
    },
    "id": "6919358778597097404"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1ShiftsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}