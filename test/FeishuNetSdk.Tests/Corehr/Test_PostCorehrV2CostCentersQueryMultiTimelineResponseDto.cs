// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询成本中心版本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询成本中心版本信息 响应体
/// <para>接口ID：7637139455451122649</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersQueryMultiTimelineResponseDto : TestBase
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
                "cost_center_id": "6969828847121885087",
                "version_id": "6969828847121885087",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "code": "MDPD00000023",
                "parent_cost_center_id": "6862995757234914824",
                "managers": [
                    "6862995757234914824"
                ],
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "effective_date": "2020-01-01",
                "expiration_date": "2020-01-01",
                "active": true
            }
        ],
        "page_token": "6969828847121885087",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostCentersQueryMultiTimelineResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}