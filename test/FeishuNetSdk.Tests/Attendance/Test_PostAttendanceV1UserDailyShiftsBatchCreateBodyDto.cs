namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 创建或修改排班表 请求体
/// <para>接口ID：7044467124773388289</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_daily_shift/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_daily_shift%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserDailyShiftsBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_daily_shifts": [
        {
            "group_id": "6737202939523236110",
            "shift_id": "6753520403404030215",
            "month": 202101,
            "user_id": "abd754f7",
            "day_no": 21,
            "is_clear_schedule": true
        }
    ],
    "operator_id": "dd31248a"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserDailyShiftsBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}