// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1ArchiveRuleUserStatsFieldsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询归档报表表头 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询归档报表表头 请求体
/// <para>接口ID：7368679915980898306</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/user_stats_fields_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2fuser_stats_fields_query</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1ArchiveRuleUserStatsFieldsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "locale": "zh",
    "month": "202409",
    "archive_rule_id": "1",
    "operator_id": "ax8ud"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1ArchiveRuleUserStatsFieldsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}