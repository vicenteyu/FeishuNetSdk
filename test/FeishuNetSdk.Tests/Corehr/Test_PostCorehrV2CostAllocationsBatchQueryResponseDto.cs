// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostAllocationsBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询成本分摊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询成本分摊 响应体
/// <para>接口ID：7486406573931757571</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/cost_allocation/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_allocation%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostAllocationsBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "employment_id": "7475686493613920050",
                "cost_allocations": [
                    {
                        "wk_id": "703912325303191204",
                        "effective_time": "2024-12-01",
                        "expiration_time": "2024-12-02",
                        "job_data_cost_center_id": [
                            {
                                "cost_center_id": "6950635856373745165",
                                "rate": 100,
                                "new_rate": 50.2
                            }
                        ],
                        "job_data_id": {
                            "wk_id": "7305354116229514796"
                        },
                        "reason": "异动"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostAllocationsBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}