// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresWithdrawOnboardingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤销入职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 撤销入职 响应体
/// <para>接口ID：7450056310967664642</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/withdraw_onboarding</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fwithdraw_onboarding</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresWithdrawOnboardingResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "success": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PreHiresWithdrawOnboardingResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}