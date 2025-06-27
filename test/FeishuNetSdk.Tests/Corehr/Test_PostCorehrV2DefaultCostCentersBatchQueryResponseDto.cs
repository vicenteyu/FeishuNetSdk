// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DefaultCostCentersBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询默认成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询默认成本中心 响应体
/// <para>接口ID：7486406573931692035</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DefaultCostCentersBatchQueryResponseDto : TestBase
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
                "default_cost_centers": [
                    {
                        "wk_id": "703912325303191204",
                        "wk_tid": "703912321231239801",
                        "effective_time": "2024-12-01",
                        "cost_center_id": "7039123253031711012",
                        "job_data_id": "7039123253031711012",
                        "is_inherit": true,
                        "inherit_source": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "中文示例"
                                }
                            ]
                        },
                        "reason": "异动"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2DefaultCostCentersBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}