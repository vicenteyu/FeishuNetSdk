namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取 Offer 申请表列表 响应体
/// <para>接口ID：7002055120885219331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_application_form%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1OfferApplicationFormsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "1234452132",
        "items": [
            {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "管培生offer申请表",
                    "en_us": "offer application form for trainee"
                },
                "create_time": "1628512038000"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1OfferApplicationFormsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}