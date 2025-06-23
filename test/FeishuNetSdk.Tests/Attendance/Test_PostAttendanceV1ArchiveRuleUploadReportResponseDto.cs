namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 写入归档报表结果 响应体
/// <para>接口ID：7368679915980914690</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/upload_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fupload_report</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ArchiveRuleUploadReportResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "invalid_code": [
            "1"
        ],
        "invalid_member_id": [
            "a1xud"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1ArchiveRuleUploadReportResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}