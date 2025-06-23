namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取工作日历日期详情 响应体
/// <para>接口ID：7408403062694084611</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar_date</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar_date</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeavesWorkCalendarDateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "calendar_dates": [
            {
                "calendar_id": "7390282135276635692",
                "date": "2006-01-02",
                "date_type": "day_off",
                "id": "7390282135276635692"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1LeavesWorkCalendarDateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}