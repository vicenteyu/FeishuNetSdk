// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-03
//
// Last Modified By : yxr
// Last Modified On : 2025-09-03
// ************************************************************************
// <copyright file="Test_PostCalendarV4FreebusyBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询主日历日程忙闲信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 批量查询主日历日程忙闲信息 响应体
/// <para>接口ID：7327132452408426500</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2ffreebusy%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4FreebusyBatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "freebusy_lists": [
            {
                "freebusy_items": [
                    {
                        "start_time": "2020-10-28T22:30:00+08:00",
                        "end_time": "2020-10-28T22:45:00+08:00",
                        "rsvp_status": "needs_action"
                    }
                ],
                "user_id": "ou_c186b6833e2d5faf2bc587e71ddabcef"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4FreebusyBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}