// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-03
//
// Last Modified By : yxr
// Last Modified On : 2025-09-03
// ************************************************************************
// <copyright file="Test_PostCalendarV4FreebusyBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询主日历日程忙闲信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 批量查询主日历日程忙闲信息 请求体
/// <para>接口ID：7327132452408426500</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4FreebusyBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "time_min": "2020-10-28T12:00:00+08:00",
    "time_max": "2020-10-29T12:00:00+08:00",
    "user_ids": [
        "ou_c186b6833e2d5faf2bc587e71ddabcef"
    ],
    "include_external_calendar": true,
    "only_busy": true
}
""";
        var result = Deserialize<FeishuNetSdk.Calendar.PostCalendarV4FreebusyBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}