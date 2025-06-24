// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ApplicationsByApplicationIdCancelOnboardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 取消候选人入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 取消候选人入职 请求体
/// <para>接口ID：6989078472837152771</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/cancel_onboard</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcancel_onboard</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsByApplicationIdCancelOnboardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "termination_type": 1,
    "termination_reason_id_list": [
        "6959090661225640000"
    ],
    "termination_reason_notes": "候选人经历不匹配"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsByApplicationIdCancelOnboardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}