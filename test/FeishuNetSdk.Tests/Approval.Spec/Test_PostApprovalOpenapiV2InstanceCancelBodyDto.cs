// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceCancelBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批实例撤回 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 审批实例撤回 请求体
/// <para>接口ID：6907569743419670530</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/approval-instance-cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDNyUjL2QjM14iN0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceCancelBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "open_id": "ou_123456",
    "user_id": "f7cb567e"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceCancelBodyDto>(json);
        Assert.IsNotNull(result);
    }
}