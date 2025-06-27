// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4InstancesByInstanceIdCommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建评论 响应体
/// <para>接口ID：7117964632137154563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesByInstanceIdCommentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "comment_id": "7081516627711606803"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4InstancesByInstanceIdCommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}