// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索成本中心信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索成本中心信息 请求体
/// <para>接口ID：7225452763517075459</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "cost_center_id_list": [
        "7140964208476371111"
    ],
    "name_list": [
        "技术部成本中心"
    ],
    "code": "MDPD00000023",
    "parent_cost_center_id": "6862995757234914824",
    "get_all_version": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CostCentersSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}