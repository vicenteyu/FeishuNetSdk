namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新实习 Offer 入/离职状态 响应体
/// <para>接口ID：7143222622736957442</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/intern_offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fintern_offer_status</para>
/// </summary>
[TestClass]
public class Test_PostHireV1OffersByOfferIdInternOfferStatusResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "offer_id": "6949805467799537964",
        "operation": "confirm_onboarding",
        "onboarding_info": {
            "actual_onboarding_date": "2022-01-01"
        },
        "offboarding_info": {
            "actual_offboarding_date": "2022-03-02",
            "notes": "主动离职"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1OffersByOfferIdInternOfferStatusResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}