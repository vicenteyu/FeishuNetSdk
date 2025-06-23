namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新 Offer 申请表自定义字段 请求体
/// <para>接口ID：7109767413990866947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_custom_field%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1OfferCustomFieldsByOfferCustomFieldIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": {
        "zh_cn": "就职状态",
        "en_us": "Employment status"
    },
    "config": {
        "options": [
            {
                "name": {
                    "zh_cn": "无业",
                    "en_us": "Unemployed"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1OfferCustomFieldsByOfferCustomFieldIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}