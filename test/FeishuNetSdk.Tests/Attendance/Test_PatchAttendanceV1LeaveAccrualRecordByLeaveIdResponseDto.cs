namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 修改发放记录 响应体
/// <para>接口ID：7239198678939713540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/leave_accrual_record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fleave_accrual_record%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchAttendanceV1LeaveAccrualRecordByLeaveIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "record": {
            "id": "6893014062142064135",
            "employment_id": "6982509313466189342",
            "leave_type_id": "6893014062142064135",
            "granting_quantity": "1",
            "granting_unit": 1,
            "effective_date": "2020-01-01",
            "expiration_date": "2020-01-01",
            "granted_by": 1,
            "reason": [
                {
                    "lang": "zh_CN",
                    "value": "test"
                }
            ],
            "created_at": "1687428000",
            "created_by": "6982509313466189342",
            "updated_at": "1687428000",
            "updated_by": "6982509313466189342"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PatchAttendanceV1LeaveAccrualRecordByLeaveIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}