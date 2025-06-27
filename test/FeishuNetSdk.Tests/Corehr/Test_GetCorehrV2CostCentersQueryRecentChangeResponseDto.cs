// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV2CostCentersQueryRecentChangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询当前生效信息发生变更的成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询当前生效信息发生变更的成本中心 响应体
/// <para>接口ID：7447798339566436355</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/cost_center/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2CostCentersQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "cost_center_ids": [
            "7094136522860922111"
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "deleted_cost_center_ids": [
            "7094136522860922111"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2CostCentersQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}