// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCalendarV4CalendarsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询日历列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询日历列表 响应体
/// <para>接口ID：6952888507002880027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCalendarV4CalendarsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": false,
        "page_token": "",
        "sync_token": "ListCalendarsSyncToken_xxx",
        "calendar_list": [
            {
                "calendar_id": "feishu.cn_xxxxxxxxxx@group.calendar.feishu.cn",
                "summary": "测试日历",
                "description": "使用开放接口创建日历",
                "permissions": "private",
                "color": -1,
                "type": "shared",
                "summary_alias": "日历备注名",
                "is_deleted": false,
                "is_third_party": false,
                "role": "owner"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.GetCalendarV4CalendarsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}