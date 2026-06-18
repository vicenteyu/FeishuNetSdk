// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_PostApprovalV4TasksAddSignBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 审批任务加签（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 审批任务加签（用户级） 请求体
/// <para>接口ID：7651444911796505794</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/add_sign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fadd_sign</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksAddSignBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_code": "289330DE-FBF1-4A47-91F9-9EFCCF11BCAE",
    "task_id": "6955096766400167956",
    "comment": "因制度要求，增加业务审批",
    "add_sign_user_ids": [
        "123456789"
    ],
    "add_sign_type": 1,
    "approval_method": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksAddSignBodyDto>(json);
        Assert.IsNotNull(result);
    }
}