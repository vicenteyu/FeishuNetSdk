// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4CalendarsByCalendarIdAclsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建访问控制 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 创建访问控制 响应体
/// <para>接口ID：6952888507002814491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-acl/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-acl%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4CalendarsByCalendarIdAclsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "acl_id": "user_xxxxxx",
        "role": "writer",
        "scope": {
            "type": "user",
            "user_id": "ou_xxxxxx"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4CalendarsByCalendarIdAclsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}