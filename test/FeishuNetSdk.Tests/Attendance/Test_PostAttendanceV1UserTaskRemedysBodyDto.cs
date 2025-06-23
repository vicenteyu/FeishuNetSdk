namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 通知补卡审批发起 请求体
/// <para>接口ID：7044467124773715969</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTaskRemedysBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "abd754f7",
    "remedy_date": 20210701,
    "punch_no": 0,
    "work_type": 1,
    "remedy_time": "2021-07-01 08:00",
    "reason": "忘记打卡",
    "time": "-"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserTaskRemedysBodyDto>(json);
        Assert.IsNotNull(result);
    }
}