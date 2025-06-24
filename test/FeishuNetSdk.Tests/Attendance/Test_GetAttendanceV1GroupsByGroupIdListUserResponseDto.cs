// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetAttendanceV1GroupsByGroupIdListUserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询考勤组下所有成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 查询考勤组下所有成员 响应体
/// <para>接口ID：7439549206763372546</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/group/list_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2flist_user</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1GroupsByGroupIdListUserResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "users": [
            {
                "user_id": "5874663B",
                "department_ids": [
                    "od-fcb45c28a45311afd440b7869541fce8"
                ]
            }
        ],
        "page_token": "92xKiuWrBCSweSZJBSTpag%3D%3D",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1GroupsByGroupIdListUserResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}