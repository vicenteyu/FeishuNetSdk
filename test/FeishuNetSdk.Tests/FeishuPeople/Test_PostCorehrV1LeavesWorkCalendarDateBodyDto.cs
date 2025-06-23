namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取工作日历日期详情 请求体
/// <para>接口ID：7408403062694084611</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar_date</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar_date</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeavesWorkCalendarDateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "wk_calendar_ids": [
        "7390282135276635692"
    ],
    "dates": [
        "2006-01-02"
    ],
    "begin_date": "2006-01-02",
    "end_date": "2006-01-02",
    "offset": 0,
    "limit": 10,
    "ids": [
        "7390282135276635692"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1LeavesWorkCalendarDateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}