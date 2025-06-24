// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发布职位广告 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 发布职位广告 请求体
/// <para>接口ID：7012986483075547137</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/publish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fadvertisement%2fpublish</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_channel_id": "6960663240925956631"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AdvertisementsByAdvertisementIdPublishBodyDto>(json);
        Assert.IsNotNull(result);
    }
}