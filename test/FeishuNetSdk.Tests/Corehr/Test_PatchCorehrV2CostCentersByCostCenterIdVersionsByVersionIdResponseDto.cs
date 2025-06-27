// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更正成本中心版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更正成本中心版本 响应体
/// <para>接口ID：7225452763517190147</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/cost_center-version/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center-version%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "version": {
            "cost_center_id": "6969828847121885087",
            "version_id": "6969828847121885087",
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
                    "value": "中文示例"
                }
            ],
            "effective_time": "2020-01-01",
            "expiration_time": "2020-01-01",
            "active": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}