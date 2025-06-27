// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2CostCentersByCostCenterIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启用 / 停用成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启用 / 停用成本中心 请求体
/// <para>接口ID：7225452763517206531</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2CostCentersByCostCenterIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "effective_time": "2020-01-01",
    "active": true,
    "operation_reason": "强行操作"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2CostCentersByCostCenterIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}