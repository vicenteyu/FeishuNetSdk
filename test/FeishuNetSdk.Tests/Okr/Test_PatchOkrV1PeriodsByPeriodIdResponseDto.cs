namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 修改 OKR 周期状态 响应体
/// <para>接口ID：7177567881395732508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchOkrV1PeriodsByPeriodIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "period_id": "6969864184272078374",
        "status": 1
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PatchOkrV1PeriodsByPeriodIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}