// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建审批实例 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 创建审批实例 响应体
/// <para>接口ID：6907569524100874241</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/create-approval-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyUjLyQjM14iM0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "instance_code":"81D31358-93AF-92D6-7425-01A5D67C4E71"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}