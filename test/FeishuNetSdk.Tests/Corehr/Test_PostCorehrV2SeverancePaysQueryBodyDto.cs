// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="Test_PostCorehrV2SeverancePaysQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索被动解除补偿金信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索被动解除补偿金信息 请求体
/// <para>接口ID：7667872540325727194</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SeverancePaysQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_ids": [
        "7659617611689510444"
    ],
    "severance_pay_ids": [
        "7660423757252773420"
    ],
    "statuses": [
        "withdrawn"
    ],
    "calculate_statuses": [
        "success"
    ],
    "apply_initiating_time_start": "1783994400",
    "apply_initiating_time_end": "1783994400",
    "offboarding_date_start": "2026-08-26",
    "offboarding_date_end": "2026-08-26",
    "select_fields": [
        "offboarding_date"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2SeverancePaysQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}