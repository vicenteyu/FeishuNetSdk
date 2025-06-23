namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询货币信息 请求体
/// <para>接口ID：7301516605753163779</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/currency/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-currency%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoCurrenciesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "currency_id_list": [
        "6863329932261459464"
    ],
    "status_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoCurrenciesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}