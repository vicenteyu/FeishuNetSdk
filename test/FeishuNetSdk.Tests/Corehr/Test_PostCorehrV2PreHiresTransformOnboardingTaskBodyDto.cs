// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-25
//
// Last Modified By : yxr
// Last Modified On : 2025-09-25
// ************************************************************************
// <copyright file="Test_PostCorehrV2PreHiresTransformOnboardingTaskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 流转入职任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 流转入职任务 请求体
/// <para>接口ID：7525488347772682242</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/transform_onboarding_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransform_onboarding_task</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PreHiresTransformOnboardingTaskBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pre_hire_id": "7345005664477775407",
    "task_code": "27691344-699b-47fb-a352-7b41e992a536",
    "transform_type": "review_task",
    "review_decision": "approve",
    "reason": "信息填写完整，允许通过"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PreHiresTransformOnboardingTaskBodyDto>(json);
        Assert.IsNotNull(result);
    }
}