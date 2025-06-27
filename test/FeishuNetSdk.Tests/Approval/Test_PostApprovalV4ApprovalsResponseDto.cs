// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4ApprovalsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建审批定义 响应体
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ApprovalsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
        "approval_id": "7090754740375519252"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4ApprovalsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}