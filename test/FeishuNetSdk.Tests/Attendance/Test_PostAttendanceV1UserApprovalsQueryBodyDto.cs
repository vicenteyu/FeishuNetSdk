namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 获取审批数据 请求体
/// <para>接口ID：7108645368100257794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_approval%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserApprovalsQueryBodyDto : TestBase
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
    "check_date_type": "PeriodTime",
    "status": 2,
    "check_time_from": "1566641088",
    "check_time_to": "1592561088"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserApprovalsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}