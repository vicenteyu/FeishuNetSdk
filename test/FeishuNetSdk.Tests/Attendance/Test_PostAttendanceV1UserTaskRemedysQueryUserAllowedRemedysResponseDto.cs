namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 获取可补卡时间 响应体
/// <para>接口ID：7044467124773453825</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query_user_allowed_remedys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery_user_allowed_remedys</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_allowed_remedys": [
            {
                "user_id": "abd754f7",
                "remedy_date": 20210104,
                "is_free_punch": false,
                "punch_no": 0,
                "work_type": 1,
                "punch_status": "Lack",
                "normal_punch_time": "2021-07-01 09:00",
                "remedy_start_time": "2021-07-01 08:00",
                "remedy_end_time": "2021-07-01 10:00"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}