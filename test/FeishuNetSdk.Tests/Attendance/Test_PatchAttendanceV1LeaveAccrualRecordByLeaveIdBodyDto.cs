namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 修改发放记录 请求体
/// <para>接口ID：7239198678939713540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_accrual_record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_accrual_record%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchAttendanceV1LeaveAccrualRecordByLeaveIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "leave_granting_record_id": "6893014062142064135",
    "employment_id": "6982509313466189342",
    "leave_type_id": "7111688079785723436",
    "reason": [
        {
            "lang": "zh_CN",
            "value": "test"
        }
    ],
    "time_offset": 480,
    "expiration_date": "2020-01-01",
    "quantity": "1"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PatchAttendanceV1LeaveAccrualRecordByLeaveIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}