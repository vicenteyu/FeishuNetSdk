namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 创建或修改考勤组 请求体
/// <para>接口ID：7044467124773683201</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1GroupsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "group": {
        "group_id": "6919358128597097404",
        "group_name": "开心考勤",
        "time_zone": "Asia/Shanghai",
        "bind_dept_ids": [
            "od-fcb45c28a45311afd440b7869541fce8"
        ],
        "except_dept_ids": [
            "od-fcb45c28a45311afd440b7869541fce8"
        ],
        "bind_user_ids": [
            "52aa1fa1"
        ],
        "except_user_ids": [
            "52aa1fa1"
        ],
        "group_leader_ids": [
            "2bg4a9be"
        ],
        "sub_group_leader_ids": [
            "52aa1fa1"
        ],
        "allow_out_punch": true,
        "out_punch_need_approval": true,
        "out_punch_need_post_approval": true,
        "out_punch_need_remark": true,
        "out_punch_need_photo": true,
        "out_punch_allowed_hide_addr": true,
        "out_punch_allowed_adjust_addr": true,
        "adjust_range": 50,
        "allow_pc_punch": true,
        "allow_remedy": true,
        "remedy_limit": true,
        "remedy_limit_count": 3,
        "remedy_date_limit": true,
        "remedy_date_num": 3,
        "allow_remedy_type_lack": true,
        "allow_remedy_type_late": true,
        "allow_remedy_type_early": true,
        "allow_remedy_type_normal": true,
        "show_cumulative_time": true,
        "show_over_time": true,
        "hide_staff_punch_time": true,
        "hide_clock_in_rule": false,
        "face_punch": true,
        "face_punch_cfg": 1,
        "face_live_need_action": false,
        "face_downgrade": true,
        "replace_basic_pic": true,
        "anti_cheat_punch_config": {
            "intercept_suspected_cheat_punch": true,
            "check_cheat_software_punch": true,
            "check_buddy_punch": true,
            "check_simulate_wifi_punch": true,
            "check_change_device_punch": true,
            "allow_change_device_num": 1,
            "suspected_cheat_handle_method": 1
        },
        "machines": [
            {
                "machine_sn": "FS0701",
                "machine_name": "创实 9 楼"
            }
        ],
        "gps_range": 300,
        "locations": [
            {
                "location_name": "浙江省杭州市余杭区五常街道木桥头西溪八方城",
                "location_type": 1,
                "latitude": 30.28994,
                "longitude": 120.04509,
                "ssid": "TP-Link-af12ca",
                "bssid": "08:00:20:0A:8C:6D",
                "map_type": 1,
                "address": "北京市海淀区中航广场",
                "ip": "122.224.123.146",
                "feature": "中国电信",
                "gps_range": 300
            }
        ],
        "group_type": 1,
        "punch_day_shift_ids": [
            "xxx",
            "0",
            "xxx",
            "xxx",
            "0",
            "xxx",
            "xxx",
            "xxx"
        ],
        "free_punch_cfg": {
            "free_start_time": "7:00",
            "free_end_time": "18:00",
            "punch_day": 1111100,
            "work_day_no_punch_as_lack": true,
            "work_hours_demand": false,
            "work_hours": 480
        },
        "calendar_id": 1,
        "need_punch_special_days": [
            {
                "punch_day": 20190101,
                "shift_id": "6919668827865513935"
            }
        ],
        "no_need_punch_special_days": [
            {
                "punch_day": 20190101,
                "shift_id": "6919668827865513935"
            }
        ],
        "work_day_no_punch_as_lack": true,
        "effect_now": true,
        "remedy_period_type": 1,
        "remedy_period_custom_date": 1,
        "punch_type": 1,
        "rest_clockIn_need_approval": true,
        "clockIn_need_photo": true,
        "member_status_change": {
            "onboarding_on_no_need_punch": false,
            "onboarding_off_no_need_punch": false,
            "offboarding_on_no_need_punch": false,
            "offboarding_off_no_need_punch": false
        },
        "leave_need_punch": false,
        "leave_need_punch_cfg": {
            "late_minutes_as_late": 0,
            "late_minutes_as_lack": 0,
            "early_minutes_as_early": 0,
            "early_minutes_as_lack": 0,
            "not_during_shift": false
        },
        "go_out_need_punch": 0,
        "go_out_need_punch_cfg": {
            "late_minutes_as_late": 0,
            "late_minutes_as_lack": 0,
            "early_minutes_as_early": 0,
            "early_minutes_as_lack": 0,
            "not_during_shift": false
        },
        "travel_need_punch": 0,
        "travel_need_punch_cfg": {
            "late_minutes_as_late": 0,
            "late_minutes_as_lack": 0,
            "early_minutes_as_early": 0,
            "early_minutes_as_lack": 0,
            "not_during_shift": false
        },
        "need_punch_members": [
            {
                "rule_scope_type": 0,
                "scope_group_list": {
                    "scope_value_type": 1,
                    "operation_type": 1,
                    "right": [
                        {
                            "key": "CH",
                            "name": "中国大陆"
                        }
                    ],
                    "member_ids": [
                        "ec8ddg56"
                    ],
                    "custom_field_ID": "123213123",
                    "custom_field_obj_type": "employment"
                }
            }
        ],
        "no_need_punch_members": [
            {
                "rule_scope_type": 0,
                "scope_group_list": {
                    "scope_value_type": 1,
                    "operation_type": 1,
                    "right": [
                        {
                            "key": "CH",
                            "name": "中国大陆"
                        }
                    ],
                    "member_ids": [
                        "ec8ddg56"
                    ],
                    "custom_field_ID": "123213123",
                    "custom_field_obj_type": "employment"
                }
            }
        ],
        "save_auto_changes": false,
        "org_change_auto_adjust": false,
        "bind_default_dept_ids": [
            "od-fcb45c28a45311afd440b7869541fce8"
        ],
        "bind_default_user_ids": [
            "dd31248a"
        ],
        "overtime_clock_cfg": {
            "allow_punch_approval": false,
            "need_clock_over_time_start_and_end": false
        },
        "new_calendar_id": "7302191700771358252",
        "allow_apply_punch": true,
        "clock_in_abnormal_settings": {
            "ignore_until_latest_clockout": false
        }
    },
    "operator_id": "dd31248a"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1GroupsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}