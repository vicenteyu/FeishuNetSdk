// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AgenciesOperateAgencyAccountBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 禁用/取消禁用猎头 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 禁用/取消禁用猎头 请求体
/// <para>接口ID：7413697955198042116</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/operate_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2foperate_agency_account</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesOperateAgencyAccountBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "option": 1,
    "id": "7398623155442682156",
    "reason": "这个人特别不负责"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AgenciesOperateAgencyAccountBodyDto>(json);
        Assert.IsNotNull(result);
    }
}