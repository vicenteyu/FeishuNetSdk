// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CompaniesActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启用/停用公司 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启用/停用公司 请求体
/// <para>接口ID：7408127338960781340</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2factive</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CompaniesActiveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "company_id": "1616161616",
    "effective_time": "2020-01-01",
    "active": true,
    "operation_reason": "业务操作"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CompaniesActiveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}