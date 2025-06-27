// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AgenciesProtectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设置猎头保护期 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 设置猎头保护期 请求体
/// <para>接口ID：6965472560995041282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/agency/protect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fprotect</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesProtectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6962051712422398239",
    "supplier_id": "6898173495386147079",
    "consultant_id": "ou_f476cb099ac9227c9bae09ce46112579",
    "protect_create_time": 1610695587000,
    "protect_expire_time": 1626333987000,
    "comment": "此候选人非常优秀，建议录用。",
    "current_salary": "15k * 13",
    "expected_salary": "18k * 16"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AgenciesProtectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}