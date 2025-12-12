// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4FreebusyListBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询主日历日程忙闲信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 查询主日历日程忙闲信息 请求体
/// <para>接口ID：6952888507002912795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2flist</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4FreebusyListBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "time_min": "2020-10-28T12:00:00+08:00",
    "time_max": "2020-12-28T12:00:00+08:00",
    "user_id": "ou_xxxxxxxxxx",
    "room_id": "omm_xxxxxxxxxx",
    "include_external_calendar": true,
    "only_busy": true,
    "need_rsvp_status": true
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4FreebusyListBodyDto>(json);
        Assert.IsNotNull(result);
    }
}