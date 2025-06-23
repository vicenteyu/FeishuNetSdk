namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 退回审批任务 请求体
/// <para>接口ID：7117964632137089027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/specified_rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fspecified_rollback</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesSpecifiedRollbackBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "893g4c45",
    "task_id": "7026591166355210260",
    "reason": "申请事项填写不具体，请重新填写",
    "extra": "demo",
    "task_def_key_list": [
        "START",
        "APPROVAL_27997_285502",
        "APPROVAL_462205_2734554"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4InstancesSpecifiedRollbackBodyDto>(json);
        Assert.IsNotNull(result);
    }
}