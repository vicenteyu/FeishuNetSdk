// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserApprovalsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 写入审批结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 写入审批结果 响应体
/// <para>接口ID：7108645368100274178</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_approval%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserApprovalsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_approval": {
            "user_id": "abd754f7",
            "date": "20210104",
            "outs": [
                {
                    "approval_id": "6737202939523236113",
                    "uniq_id": "9496E43696967658A512969523E89870",
                    "unit": 1,
                    "interval": 3600,
                    "start_time": "2021-01-04 09:00:00",
                    "end_time": "2021-01-04 19:00:00",
                    "i18n_names": {
                        "ch": "中文描述",
                        "en": "English description",
                        "ja": "日本語の説明"
                    },
                    "default_locale": "ch",
                    "reason": "外出办事",
                    "approve_pass_time": "2021-01-04 12:00:00",
                    "approve_apply_time": "2021-01-04 11:00:00",
                    "idempotent_id": "1233432312",
                    "correct_process_id": [
                        "7304865941202929196"
                    ],
                    "cancel_process_id": [
                        "7304865941202929196"
                    ],
                    "process_id": [
                        "7304865941202929196"
                    ]
                }
            ],
            "leaves": [
                {
                    "approval_id": "6737202939523236113",
                    "uniq_id": "6852582717813440527",
                    "unit": 1,
                    "interval": 3600,
                    "start_time": "2021-01-04 09:00:00",
                    "end_time": "2021-01-04 19:00:00",
                    "i18n_names": {
                        "ch": "中文描述",
                        "en": "English description",
                        "ja": "日本語の説明"
                    },
                    "default_locale": "ch",
                    "reason": "家里有事",
                    "approve_pass_time": "2021-01-04 12:00:00",
                    "approve_apply_time": "2021-01-04 11:00:00",
                    "idempotent_id": "1233432312"
                }
            ],
            "overtime_works": [
                {
                    "approval_id": "6737202939523236113",
                    "duration": 1.5,
                    "unit": 1,
                    "category": 2,
                    "type": 1,
                    "start_time": "2021-01-09 09:00:00",
                    "end_time": "2021-01-10 13:00:00",
                    "reason": "推进项目进度",
                    "idempotent_id": "1233432312",
                    "correct_process_id": [
                        "7304865941202929196"
                    ],
                    "cancel_process_id": [
                        "7304865941202929196"
                    ],
                    "process_id": [
                        "7304865941202929196"
                    ]
                }
            ],
            "trips": [
                {
                    "approval_id": "6737202939523236113",
                    "start_time": "2021-01-04 09:00:00",
                    "end_time": "2021-01-04 19:00:00",
                    "reason": "培训",
                    "approve_pass_time": "2021-01-04 12:00:00",
                    "approve_apply_time": "2021-01-04 11:00:00",
                    "idempotent_id": "1233432312",
                    "correct_process_id": [
                        "7304865941202929196"
                    ],
                    "cancel_process_id": [
                        "7304865941202929196"
                    ],
                    "process_id": [
                        "7304865941202929196"
                    ],
                    "departure": {
                        "region_level": "l1",
                        "region_id": "6863333418483058189"
                    },
                    "destinations": [
                        {
                            "region_level": "l1",
                            "region_id": "6863333418483058189"
                        }
                    ],
                    "transportation": [
                        1
                    ],
                    "trip_type": 1,
                    "remarks": "出差备注"
                }
            ],
            "time_zone": "Asia/Shanghai"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserApprovalsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}