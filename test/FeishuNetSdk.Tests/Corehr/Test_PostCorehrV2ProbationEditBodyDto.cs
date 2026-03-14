// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-14
//
// Last Modified By : yxr
// Last Modified On : 2026-03-14
// ************************************************************************
// <copyright file="Test_PostCorehrV2ProbationEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 编辑试用期 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 编辑试用期 请求体
/// <para>接口ID：7476132303751446529</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fedit</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationEditBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id": "7140964208476371111",
    "probation_start_date": "2024-01-01",
    "probation_expected_end_date": "2025-01-01",
    "probation_outcome": "passed",
    "actual_probation_end_date": "2025-01-01",
    "probation_extend_expected_end_date": "2025-01-01",
    "extended_probation_period_duration": 1,
    "extended_probation_period_unit": "day",
    "notes": "试用期表现良好。",
    "self_review": "试用期表现良好。",
    "custom_fields": [
        {
            "custom_api_name": "name",
            "name": {
                "zh_cn": "自定义姓名",
                "en_us": "Custom Name"
            },
            "type": 1,
            "value": "231"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationEditBodyDto>(json);
        Assert.IsNotNull(result);
    }
}