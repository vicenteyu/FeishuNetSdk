// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1GroupsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 按名称查询考勤组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 按名称查询考勤组 请求体
/// <para>接口ID：7044467124773781505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1GroupsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "group_name": "考勤组1"
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.PostAttendanceV1GroupsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}