// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAttendanceV1GroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询所有考勤组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询所有考勤组 响应体
/// <para>接口ID：7098332552943697922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1GroupsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "group_list": [
            {
                "group_id": "6919358128597097404",
                "group_name": "考勤组1"
            }
        ],
        "page_token": "wgNOR1rmxogRvAsGl6CXlQ==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1GroupsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}