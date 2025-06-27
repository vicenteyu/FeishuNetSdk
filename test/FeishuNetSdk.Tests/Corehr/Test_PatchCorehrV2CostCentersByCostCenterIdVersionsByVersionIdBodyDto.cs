// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更正成本中心版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更正成本中心版本 请求体
/// <para>接口ID：7225452763517190147</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/cost_center-version/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center-version%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": [
        {
            "lang": "zh-CN",
            "value": "基础架构"
        }
    ],
    "parent_cost_center_id": "6862995757234914824",
    "managers": [
        "6862995757234914824"
    ],
    "description": [
        {
            "lang": "zh-CN",
            "value": "基础架构相关业务"
        }
    ],
    "effective_time": "2020-01-01",
    "operation_reason": "强行操作"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2CostCentersByCostCenterIdVersionsByVersionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}