// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ExternalOffersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建外部 Offer 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建外部 Offer 请求体
/// <para>接口ID：7407298680640946179</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-offer-info/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_offer%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalOffersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_id": "729557715718",
    "external_application_id": "7395015673275697419",
    "biz_create_time": "1721899352428",
    "owner": "张三",
    "offer_status": "已发送",
    "attachment_id_list": [
        "7404675264888097068"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalOffersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}