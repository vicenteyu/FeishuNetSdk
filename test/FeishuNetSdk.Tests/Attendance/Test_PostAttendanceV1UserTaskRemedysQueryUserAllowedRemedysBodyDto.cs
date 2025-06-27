// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取可补卡时间 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 获取可补卡时间 请求体
/// <para>接口ID：7044467124773453825</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task_remedy/query_user_allowed_remedys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task_remedy%2fquery_user_allowed_remedys</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "abd754f7",
    "remedy_date": 20210104
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1UserTaskRemedysQueryUserAllowedRemedysBodyDto>(json);
        Assert.IsNotNull(result);
    }
}