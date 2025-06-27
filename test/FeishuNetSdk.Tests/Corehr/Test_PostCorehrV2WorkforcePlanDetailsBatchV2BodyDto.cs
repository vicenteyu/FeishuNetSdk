// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2WorkforcePlanDetailsBatchV2BodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询编制规划明细信息（支持自定义组织） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询编制规划明细信息（支持自定义组织） 请求体
/// <para>接口ID：7473343327586435100</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch_v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch_v2</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2WorkforcePlanDetailsBatchV2BodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "workforce_plan_id": "781234834512",
    "is_centralized_reporting_project": false,
    "centralized_reporting_project_id": "7140964208476371111",
    "dimension_id_in_datas": [
        {
            "dimension_key": "department",
            "dimension_ids": [
                "7210266650427033132"
            ]
        }
    ],
    "include_missing_dimension_rows": false,
    "filter_all_zero_value_rows": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2WorkforcePlanDetailsBatchV2BodyDto>(json);
        Assert.IsNotNull(result);
    }
}