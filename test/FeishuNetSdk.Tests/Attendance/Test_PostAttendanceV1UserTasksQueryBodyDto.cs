namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询打卡结果 请求体
/// <para>接口ID：7044467124773421057</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTasksQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "abd754f7"
    ],
    "check_date_from": 20190817,
    "check_date_to": 20190820,
    "need_overtime_result": true
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserTasksQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}