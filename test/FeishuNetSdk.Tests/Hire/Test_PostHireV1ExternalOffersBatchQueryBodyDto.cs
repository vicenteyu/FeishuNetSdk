namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询外部 Offer 列表 请求体
/// <para>接口ID：7407298680641060867</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalOffersBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_offer_id_list": [
        "6960663240925956660"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalOffersBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}