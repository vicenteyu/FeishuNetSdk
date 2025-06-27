// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAttendanceV1UserSettingsModifyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改用户人脸识别信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 修改用户人脸识别信息 响应体
/// <para>接口ID：7044467124773404673</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/modify</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fmodify</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1UserSettingsModifyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_setting": {
            "user_id": "abd754f7",
            "face_key": "xxxxxb306842b1c189bc5212eefxxxxx",
            "face_key_update_time": "1625681917"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1UserSettingsModifyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}