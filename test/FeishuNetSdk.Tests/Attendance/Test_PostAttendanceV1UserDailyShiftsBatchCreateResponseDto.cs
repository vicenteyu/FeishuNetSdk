// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserDailyShiftsBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建或修改排班表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 创建或修改排班表 响应体
/// <para>接口ID：7044467124773388289</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserDailyShiftsBatchCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_daily_shifts": [
            {
                "group_id": "6737202939523236110",
                "shift_id": "6753520403404030215",
                "month": 202101,
                "user_id": "abd754f7",
                "day_no": 21,
                "is_clear_schedule": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserDailyShiftsBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}