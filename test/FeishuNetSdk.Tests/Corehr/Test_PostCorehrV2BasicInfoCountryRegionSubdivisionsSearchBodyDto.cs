namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询省份/主要行政区信息 请求体
/// <para>接口ID：7301516605753245699</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region_subdivision%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "country_region_id_list": [
        "6891251722631891995"
    ],
    "country_region_subdivision_id_list": [
        "6891251222631891995"
    ],
    "status_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}