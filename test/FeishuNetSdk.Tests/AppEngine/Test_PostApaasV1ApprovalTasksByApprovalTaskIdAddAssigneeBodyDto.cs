namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 人工任务加签 请求体
/// <para>接口ID：7347562540447121409</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/add_assignee</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2fadd_assignee</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApprovalTasksByApprovalTaskIdAddAssigneeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "1783981209205788",
    "approvers": [
        "1783981209205788"
    ],
    "add_assignee_type": "currentAndAddAssign",
    "opinion": "加签"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApprovalTasksByApprovalTaskIdAddAssigneeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}