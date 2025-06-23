namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 写入归档报表结果 请求体
/// <para>接口ID：7368679915980914690</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/upload_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fupload_report</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ArchiveRuleUploadReportBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "month": "202409",
    "operator_id": "ax11d",
    "archive_report_datas": [
        {
            "member_id": "1aaxxd",
            "start_time": "20210109",
            "end_time": "20210109",
            "field_datas": [
                {
                    "code": "abd754f7",
                    "value": "1"
                }
            ]
        }
    ],
    "archive_rule_id": "1"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1ArchiveRuleUploadReportBodyDto>(json);
        Assert.IsNotNull(result);
    }
}