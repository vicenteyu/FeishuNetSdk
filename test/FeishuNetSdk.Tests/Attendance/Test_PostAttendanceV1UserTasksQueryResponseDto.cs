// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserTasksQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询打卡结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询打卡结果 响应体
/// <para>接口ID：7044467124773421057</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTasksQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_task_results": [
            {
                "result_id": "6709359313699356941",
                "user_id": "abd754f7",
                "employee_name": "张三",
                "day": 20190819,
                "group_id": "6737202939523236110",
                "shift_id": "6753520403404030215",
                "records": [
                    {
                        "check_in_record_id": "6709359313699356941",
                        "check_in_record": {
                            "user_id": "abd754f7",
                            "creator_id": "abd754f7",
                            "location_name": "西溪八方城",
                            "check_time": "1611476284",
                            "comment": "上班打卡",
                            "record_id": "6709359313699356941",
                            "ssid": "b0:b8:67:5c:1d:72",
                            "bssid": "b0:b8:67:5c:1d:72",
                            "is_field": true,
                            "is_wifi": true,
                            "type": 7,
                            "photo_urls": [
                                "https://time.clockin.biz/manage/download/6840389754748502021"
                            ],
                            "device_id": "99e0609ee053448596502691a81428654d7ded64c7bd85acd982d26b3636c37d",
                            "check_result": "Invalid",
                            "external_id": "record_123",
                            "idempotent_id": "****_***"
                        },
                        "check_out_record_id": "6709359313699356942",
                        "check_out_record": {
                            "user_id": "abd754f7",
                            "creator_id": "abd754f7",
                            "location_name": "西溪八方城",
                            "check_time": "1611476284",
                            "comment": "上班打卡",
                            "record_id": "6709359313699356941",
                            "ssid": "b0:b8:67:5c:1d:72",
                            "bssid": "b0:b8:67:5c:1d:72",
                            "is_field": true,
                            "is_wifi": true,
                            "type": 7,
                            "photo_urls": [
                                "https://time.clockin.biz/manage/download/6840389754748502021"
                            ],
                            "device_id": "99e0609ee053448596502691a81428654d7ded64c7bd85acd982d26b3636c37d",
                            "check_result": "Invalid",
                            "external_id": "record_123",
                            "idempotent_id": "****_***"
                        },
                        "check_in_result": "SystemCheck",
                        "check_out_result": "SystemCheck",
                        "check_in_result_supplement": "None",
                        "check_out_result_supplement": "None",
                        "check_in_shift_time": "1609722000",
                        "check_out_shift_time": "1609754400",
                        "task_shift_type": 0
                    }
                ]
            }
        ],
        "invalid_user_ids": [
            "abd754f7"
        ],
        "unauthorized_user_ids": [
            "abd754f7"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserTasksQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}