namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 根据适用条件获取工作日历 ID 响应体
/// <para>接口ID：7412526256520724508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/leave/calendar_by_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fcalendar_by_scope</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1LeavesCalendarByScopeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "calendar_wk_id": "6722331851580982798"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1LeavesCalendarByScopeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}