// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHireV1OffersByOfferIdOfferStatusBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新 Offer 状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新 Offer 状态 请求体
/// <para>接口ID：7219143467641487363</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2foffer_status</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1OffersByOfferIdOfferStatusBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "offer_status": 6,
    "expiration_date": "2023-01-01",
    "termination_reason_id_list": [
        "6891560630172518670"
    ],
    "termination_reason_note": "不符合期望"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1OffersByOfferIdOfferStatusBodyDto>(json);
        Assert.IsNotNull(result);
    }
}