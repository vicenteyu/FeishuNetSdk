namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新外部 Offer 请求体
/// <para>接口ID：7407298680641093635</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1ExternalOffersByExternalOfferIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_application_id": "7395015673275697419",
    "biz_create_time": "1721899352428",
    "owner": "张三",
    "offer_status": "已发送",
    "attachment_id_list": [
        "7404675264888097068"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1ExternalOffersByExternalOfferIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}