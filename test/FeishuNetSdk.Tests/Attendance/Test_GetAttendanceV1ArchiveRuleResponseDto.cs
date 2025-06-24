// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAttendanceV1ArchiveRuleResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询所有归档规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询所有归档规则 响应体
/// <para>接口ID：7368679915980947458</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/archive_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2farchive_rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1ArchiveRuleResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "report_id": "7341290237441605652",
                "report_name": {
                    "zh": "1",
                    "en": "alice",
                    "ja": "1"
                },
                "archive_rule_id": "7341290237441605652",
                "archive_rule_name": {
                    "zh": "1",
                    "en": "alice",
                    "ja": "1"
                }
            }
        ],
        "page_token": "xxx",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1ArchiveRuleResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}