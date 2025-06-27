// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1ApplicationsByApplicationIdTransferStageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转移投递阶段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 转移投递阶段 请求体
/// <para>接口ID：6989078472837136387</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/transfer_stage</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2ftransfer_stage</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ApplicationsByApplicationIdTransferStageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "stage_id": "6960663240925956402"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ApplicationsByApplicationIdTransferStageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}