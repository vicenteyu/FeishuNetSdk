// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1TestsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取笔试列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取笔试列表 请求体
/// <para>接口ID：7127207246887796740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftest%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TestsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "application_id_list": [
        "7230753910687080000"
    ],
    "test_start_time_min": "1608725989000",
    "test_start_time_max": "1608726999000"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TestsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}