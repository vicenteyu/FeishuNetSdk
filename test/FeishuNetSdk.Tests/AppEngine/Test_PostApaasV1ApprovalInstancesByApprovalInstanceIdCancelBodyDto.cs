namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 撤销人工任务 请求体
/// <para>接口ID：7446337145820364804</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_instance%2fcancel</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApprovalInstancesByApprovalInstanceIdCancelBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "1234",
    "opinion": "撤销了"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApprovalInstancesByApprovalInstanceIdCancelBodyDto>(json);
        Assert.IsNotNull(result);
    }
}