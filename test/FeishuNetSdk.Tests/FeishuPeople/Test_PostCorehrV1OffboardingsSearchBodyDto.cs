namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 搜索离职信息 请求体
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1OffboardingsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ],
    "apply_initiating_time_start": "1672578336",
    "apply_initiating_time_end": "1674133537",
    "apply_finished_time_start": "1641007353",
    "apply_finished_time_end": "1641007353",
    "expected_offboarding_date_start": "2022-01-01",
    "expected_offboarding_date_end": "2022-01-01",
    "offboarding_date_start": "2022-01-01",
    "offboarding_date_end": "2022-01-01",
    "statuses": [
        "Approving"
    ],
    "reasons": [
        "voluntary"
    ],
    "employee_reasons": [
        "voluntary"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1OffboardingsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}