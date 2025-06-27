// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过过期时间获取发放记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 通过过期时间获取发放记录 响应体
/// <para>接口ID：7239198678939697156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_employ_expire_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_employ_expire_record%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "records": [
            {
                "id": "6893014062142064135",
                "employment_id": "6982509313466189342",
                "leave_type_id": "6893014062142064135",
                "granting_quantity": "1",
                "left_granting_quantity": "1",
                "granting_unit": 1,
                "effective_date": "2020-01-01",
                "expiration_date": "2020-01-01",
                "reason": [
                    {
                        "lang": "zh_CN",
                        "value": "test"
                    }
                ],
                "is_update_by_external": true,
                "accrual_source": 1,
                "leave_sub_type_id": "6893014062142064135",
                "section_type": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}