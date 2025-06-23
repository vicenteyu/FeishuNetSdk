namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 批量查询用户人脸识别信息 响应体
/// <para>接口ID：7044467124773584897</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1UserSettingsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_settings": [
            {
                "user_id": "abd754f7",
                "face_key": "xxxxxb306842b1c189bc5212eefxxxxx",
                "face_key_update_time": "1625681917"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.GetAttendanceV1UserSettingsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}