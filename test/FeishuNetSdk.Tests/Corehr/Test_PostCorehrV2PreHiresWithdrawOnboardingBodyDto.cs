// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresWithdrawOnboardingBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤销入职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销入职 请求体
/// <para>接口ID：7450056310967664642</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/withdraw_onboarding</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fwithdraw_onboarding</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresWithdrawOnboardingBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pre_hire_id": "7345005664477775407",
    "withdraw_reason": "withdraw reason"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresWithdrawOnboardingBodyDto>(json);
        Assert.IsNotNull(result);
    }
}