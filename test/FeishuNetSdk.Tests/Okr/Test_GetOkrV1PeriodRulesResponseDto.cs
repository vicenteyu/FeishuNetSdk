// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetOkrV1PeriodRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 OKR 周期规则 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取 OKR 周期规则 响应体
/// <para>接口ID：7177567881395699740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod_rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV1PeriodRulesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "period_rules": [
            {
                "period_rule_id": "134",
                "type": "year",
                "length": 12,
                "first_month": 12
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV1PeriodRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}