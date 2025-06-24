// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1JobsByJobIdOpenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 重启职位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 重启职位 请求体
/// <para>接口ID：7012986483075530753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fopen</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobsByJobIdOpenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "expiry_time": 1830259120000,
    "is_never_expired": true
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobsByJobIdOpenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}