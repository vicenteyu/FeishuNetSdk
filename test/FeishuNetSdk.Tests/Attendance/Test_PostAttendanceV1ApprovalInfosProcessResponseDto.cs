namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 通知审批状态更新 响应体
/// <para>接口ID：7108645368100290562</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_approval/process</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fapproval_info%2fprocess</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ApprovalInfosProcessResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_info": {
            "approval_id": "6737202939523236113",
            "approval_type": "remedy",
            "status": 0
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1ApprovalInfosProcessResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}