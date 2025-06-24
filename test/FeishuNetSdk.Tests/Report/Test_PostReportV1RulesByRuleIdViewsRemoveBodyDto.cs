// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostReportV1RulesByRuleIdViewsRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移除规则看板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Report;

/// <summary>
/// 测试 移除规则看板 请求体
/// <para>接口ID：6993276991760056323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/rule-view/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2frule-view%2fremove</para>
/// </summary>
[TestClass]
public class Test_PostReportV1RulesByRuleIdViewsRemoveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": ["ou_c26134180ba2611aede183e5e3b531ed"]
}
""";
        var result = Deserialize<FeishuNetSdk.Report.PostReportV1RulesByRuleIdViewsRemoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}