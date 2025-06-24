// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ApplicationsDiversityInclusionsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取申请表附加信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取申请表附加信息 请求体
/// <para>接口ID：7232192298414292993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fdiversity_inclusion%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsDiversityInclusionsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_ids": [
        "6784008015948283905"
    ],
    "application_ids": [
        "6784008015948283907"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsDiversityInclusionsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}