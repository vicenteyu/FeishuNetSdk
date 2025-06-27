// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DefaultCostCentersUpdateVersionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新默认成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新默认成本中心 请求体
/// <para>接口ID：7486406573931642883</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/update_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fupdate_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DefaultCostCentersUpdateVersionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "6862995757234914821",
    "default_cost_center": {
        "wk_id": "703912325303191204",
        "wk_tid": "703912321231239801",
        "effective_time": "2024-12-01",
        "cost_center_id": "7039123253031711012",
        "is_inherit": false,
        "reason": "异动"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DefaultCostCentersUpdateVersionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}