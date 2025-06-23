namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 获取访问控制列表 响应体
/// <para>接口ID：6953067803433009153</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsByCalendarIdAclsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "acls": [
            {
                "acl_id": "user_xxxxxx",
                "role": "writer",
                "scope": {
                    "type": "user",
                    "user_id": "ou_xxxxxx"
                }
            }
        ],
        "has_more": false,
        "page_token": "xxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsByCalendarIdAclsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}