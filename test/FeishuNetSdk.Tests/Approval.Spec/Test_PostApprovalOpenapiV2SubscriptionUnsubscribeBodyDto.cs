// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2SubscriptionUnsubscribeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 取消订阅审批事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 取消订阅审批事件 请求体
/// <para>接口ID：6907569524100546561</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/cancel-a-subscription-to-an-approvals-event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDOyUjL4gjM14CO4ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2SubscriptionUnsubscribeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code":"7C468A54-8745-2245-9675-08B7C63E7A85"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2SubscriptionUnsubscribeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}