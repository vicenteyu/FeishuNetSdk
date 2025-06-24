// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2ProbationEnableDisableAssessmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启用/停用试用期考核功能 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启用/停用试用期考核功能 请求体
/// <para>接口ID：7254814386694569986</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/enable_disable_assessment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fenable_disable_assessment</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProbationEnableDisableAssessmentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "active": true,
    "app_url": "https://qwe111.feishuapp.bytedance.net/ae/ui/apps/176612345027111/appPages/l11bsrwss13yt?dataGrid%41pye4fsbajo21l=%7B%7D&key=ffm41o1&dataGrid%41wmv98t29vif3kj=%1B%7D"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProbationEnableDisableAssessmentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}