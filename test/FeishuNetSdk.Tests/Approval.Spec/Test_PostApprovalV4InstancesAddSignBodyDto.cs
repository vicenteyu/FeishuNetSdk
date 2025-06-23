namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 审批任务加签 请求体
/// <para>接口ID：6968270299335606273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/approval-task-addsign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-task-addsign</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesAddSignBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "3B68E280-CF10-4198-B4CD-2E3BB97981D8",
    "instance_code": "289330DE-FBF1-4A47-91F9-9EFCCF11BCAE",
    "user_id": "b16g66e3",
    "task_id": "6955096766400167956",
    "comment": "addSignComment",
    "add_sign_user_ids": ["d19b913b","3313g62b"],
    "add_sign_type": 1,
    "approval_method": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalV4InstancesAddSignBodyDto>(json);
        Assert.IsNotNull(result);
    }
}