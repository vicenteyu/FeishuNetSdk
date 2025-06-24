// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostAllocationsUpdateVersionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新成本分摊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新成本分摊 请求体
/// <para>接口ID：7486406573931708419</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/update_version</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fupdate_version</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostAllocationsUpdateVersionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "6862995757234914821",
    "cost_allocation": {
        "wk_id": "703912325303191204",
        "effective_time": "2024-12-01",
        "expiration_time": "2024-12-02",
        "job_data_cost_center_id": [
            {
                "cost_center_id": "6950635856373745165",
                "new_rate": 50.2
            }
        ],
        "reason": "异动"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CostAllocationsUpdateVersionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}