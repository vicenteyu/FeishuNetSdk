// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建成本中心 响应体
/// <para>接口ID：7225452763517140995</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "cost_center": {
            "cost_center_id": "6969828847121885087",
            "cost_center_version_id": "6969828847121885087",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "基础架构"
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
                    "value": "基础架构相关内容"
                }
            ],
            "effective_time": "2020-01-01",
            "expiration_time": "2020-01-01",
            "active": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CostCentersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}