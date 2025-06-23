namespace FeishuNetSdk.Tests.Attendance;

/// <summary>
/// 测试 按名称查询考勤组 响应体
/// <para>接口ID：7044467124773781505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/group/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fgroup%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostAttendanceV1GroupsSearchResponseDto : TestBase
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
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Attendance.PostAttendanceV1GroupsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}