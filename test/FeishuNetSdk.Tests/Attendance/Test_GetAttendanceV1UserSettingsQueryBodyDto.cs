namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 批量查询用户人脸识别信息 请求体
/// <para>接口ID：7044467124773584897</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetAttendanceV1UserSettingsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "abd754f7"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Attendance.GetAttendanceV1UserSettingsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}