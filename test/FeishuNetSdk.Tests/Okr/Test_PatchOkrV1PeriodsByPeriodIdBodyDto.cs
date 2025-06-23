namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 修改 OKR 周期状态 请求体
/// <para>接口ID：7177567881395732508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchOkrV1PeriodsByPeriodIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Okr.PatchOkrV1PeriodsByPeriodIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}