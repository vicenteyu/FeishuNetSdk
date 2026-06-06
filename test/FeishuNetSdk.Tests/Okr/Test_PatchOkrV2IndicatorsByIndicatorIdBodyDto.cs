// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PatchOkrV2IndicatorsByIndicatorIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新量化指标 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 更新量化指标 请求体
/// <para>接口ID：7644764969658207180</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-indicator/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-indicator%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchOkrV2IndicatorsByIndicatorIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "current_value_calculate_type": 0,
    "status_calculate_type": 0,
    "start_value": 0,
    "target_value": 0,
    "current_value": 0,
    "unit": {
        "unit_type": 0,
        "unit_value": "PERCENT"
    },
    "indicator_status": 0
}
""";
        var result = Deserialize<FeishuNetSdk.Okr.PatchOkrV2IndicatorsByIndicatorIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}