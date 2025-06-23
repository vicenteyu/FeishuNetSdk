namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 同意审批任务 请求体
/// <para>接口ID：7114621541589893123</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fapprove</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksApproveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "user_id": "f7cb567e",
    "comment": "OK",
    "task_id": "12345",
    "form": "[{\"id\":\"111\", \"type\": \"input\", \"value\":\"test\"}]"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksApproveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}