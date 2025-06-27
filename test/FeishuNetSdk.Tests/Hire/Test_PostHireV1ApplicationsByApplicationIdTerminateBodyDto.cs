// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ApplicationsByApplicationIdTerminateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 终止投递 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 终止投递 请求体
/// <para>接口ID：6964286393804832796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fterminate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsByApplicationIdTerminateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "termination_type": 1,
    "termination_reason_list": [
        "7230753910687080000"
    ],
    "termination_reason_note": "不符合期望"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsByApplicationIdTerminateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}