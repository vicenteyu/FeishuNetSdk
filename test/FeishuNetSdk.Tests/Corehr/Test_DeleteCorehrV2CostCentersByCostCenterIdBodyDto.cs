// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteCorehrV2CostCentersByCostCenterIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 删除成本中心 请求体
/// <para>接口ID：7225452763517157379</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteCorehrV2CostCentersByCostCenterIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operation_reason": "随着组织架构调整，该成本中心不再使用"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.DeleteCorehrV2CostCentersByCostCenterIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}