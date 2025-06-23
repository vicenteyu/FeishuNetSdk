namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 删除归档报表行数据 请求体
/// <para>接口ID：7368679915980931074</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/del_report</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fdel_report</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ArchiveRuleDelReportBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "month": "202409",
    "operator_id": "a111xd",
    "archive_rule_id": "1",
    "user_ids": [
        "xx1uad"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1ArchiveRuleDelReportBodyDto>(json);
        Assert.IsNotNull(result);
    }
}