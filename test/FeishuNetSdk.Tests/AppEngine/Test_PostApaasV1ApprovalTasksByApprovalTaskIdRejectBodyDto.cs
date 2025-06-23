namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 拒绝人工任务 请求体
/// <para>接口ID：7347562540447088641</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/reject</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2freject</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApprovalTasksByApprovalTaskIdRejectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "1783981209205788",
    "opinion": "拒绝"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApprovalTasksByApprovalTaskIdRejectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}