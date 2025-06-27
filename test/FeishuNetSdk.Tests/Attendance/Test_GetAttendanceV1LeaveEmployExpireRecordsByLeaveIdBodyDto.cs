// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过过期时间获取发放记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 通过过期时间获取发放记录 请求体
/// <para>接口ID：7239198678939697156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_employ_expire_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_employ_expire_record%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "6982509313466189342",
    "leave_type_id": "7111688079785723436",
    "start_expiration_date": "2023-04-10",
    "end_expiration_date": "2023-05-10",
    "time_offset": 480
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.GetAttendanceV1LeaveEmployExpireRecordsByLeaveIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}