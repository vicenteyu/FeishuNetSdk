// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 创建审批实例 请求体
/// <para>接口ID：6907569524100874241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/create-approval-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyUjLyQjM14iM0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code":"7C468A54-8745-2245-9675-08B7C63E7A85",
    "user_id":"f7cb567e",
    "open_id":"ou_123456",
    "uuid": "",
    "department_id":"",
    "form":"[{\"id\":\"user_name\", \"type\": \"input\", \"value\":\"test\"}]",
    "node_approver_user_id_list": {
        "46e6d96cfa756980907209209ec03b64": ["f7cb567e"],
        "manager_node_id": ["f7cb567e"]
    },
    "node_approver_open_id_list": {
        "46e6d96cfa756980907209209ec03b64": ["ou_12345"],
        "manager_node_id": ["ou_12345"]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}