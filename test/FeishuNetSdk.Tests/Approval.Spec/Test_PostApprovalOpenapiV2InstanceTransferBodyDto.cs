// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceTransferBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批任务转交 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 审批任务转交 请求体
/// <para>接口ID：6907569524099842049</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/approval-task-transfer</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNyUjL1QjM14SN0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceTransferBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "user_id": "f7cb567e",
    "task_id": "12345",
    "comment": "check",
    "transfer_user_id": "f4ip317q",
    "open_id": "ou_123456",
    "transfer_open_id": "ou_654321"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceTransferBodyDto>(json);
        Assert.IsNotNull(result);
    }
}