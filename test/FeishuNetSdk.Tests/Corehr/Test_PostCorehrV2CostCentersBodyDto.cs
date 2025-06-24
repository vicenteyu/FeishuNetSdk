// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建成本中心 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建成本中心 请求体
/// <para>接口ID：7225452763517140995</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": [
        {
            "lang": "zh-CN",
            "value": "基础架构相关"
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
            "value": "基础架构相关业务"
        }
    ],
    "effective_time": "2020-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CostCentersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}