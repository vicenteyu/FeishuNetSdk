// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_PostApprovalV4TasksRollbackBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 退回审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 退回审批任务（用户级） 请求体
/// <para>接口ID：7651444911796489410</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2frollback</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksRollbackBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_code": "289330DE-FBF1-4A47-91F9-9EFCCF11BCAE",
    "task_id": "6955096766400168956",
    "comment": "不符合要求，退回重新审批",
    "node_ids": [
        "46e6d96cfa756980907209209ec03b64"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksRollbackBodyDto>(json);
        Assert.IsNotNull(result);
    }
}