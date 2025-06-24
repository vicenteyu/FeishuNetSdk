// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserTaskRemedysQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取补卡记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 获取补卡记录 响应体
/// <para>接口ID：7044467124773666817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTaskRemedysQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_remedys": [
            {
                "user_id": "abd754f7",
                "remedy_date": 20210701,
                "punch_no": 0,
                "work_type": 1,
                "approval_id": "6737202939523236113",
                "remedy_time": "2021-07-01 08:00",
                "status": 2,
                "reason": "忘记打卡",
                "time": "1611476284",
                "time_zone": "Asia/Shanghai",
                "create_time": "1611476284",
                "update_time": "1611476284"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserTaskRemedysQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}