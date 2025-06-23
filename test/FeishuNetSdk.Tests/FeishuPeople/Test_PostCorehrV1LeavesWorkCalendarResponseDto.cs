namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取工作日历 响应体
/// <para>接口ID：7408403062694100995</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/work_calendar</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fwork_calendar</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1LeavesWorkCalendarResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "work_calendars": [
            {
                "calendar_id": "7136914415957591596",
                "calendar_name": {
                    "zh_cn": "日历1",
                    "en_us": "calendar1"
                },
                "enable": true
            }
        ],
        "count": 20
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1LeavesWorkCalendarResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}