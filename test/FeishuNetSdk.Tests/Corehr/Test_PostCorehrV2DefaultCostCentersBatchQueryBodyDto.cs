// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DefaultCostCentersBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询默认成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询默认成本中心 请求体
/// <para>接口ID：7486406573931692035</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DefaultCostCentersBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7140964208476371111"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DefaultCostCentersBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}