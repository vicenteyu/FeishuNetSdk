namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询区/县信息 请求体
/// <para>接口ID：7301516605753147395</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-district%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoDistrictsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "city_id_list": [
        "6863333352603125255"
    ],
    "district_id_list": [
        "6863333353496512007"
    ],
    "status_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoDistrictsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}