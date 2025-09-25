// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-25
//
// Last Modified By : yxr
// Last Modified On : 2025-09-25
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresTransformOnboardingTaskResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 流转入职任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 流转入职任务 响应体
/// <para>接口ID：7525488347772682242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/transform_onboarding_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransform_onboarding_task</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresTransformOnboardingTaskResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2PreHiresTransformOnboardingTaskResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}