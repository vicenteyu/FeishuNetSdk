// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2CostCentersTreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定生效日期的成本中心架构树 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定生效日期的成本中心架构树 请求体
/// <para>接口ID：7637139455451139033</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2ftree</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CostCentersTreeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "cost_center_id": "7140964208476371111",
    "need_inactive": false,
    "effective_date": "2024-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CostCentersTreeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}