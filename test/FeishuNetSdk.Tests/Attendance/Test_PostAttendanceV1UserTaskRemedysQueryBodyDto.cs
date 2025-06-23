namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 获取补卡记录 请求体
/// <para>接口ID：7044467124773666817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTaskRemedysQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "abd754f7"
    ],
    "check_time_from": "1566641088",
    "check_time_to": "1592561088",
    "status": 2
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserTaskRemedysQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}