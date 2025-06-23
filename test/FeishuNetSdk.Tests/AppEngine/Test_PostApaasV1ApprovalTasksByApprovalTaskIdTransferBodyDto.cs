namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 转交人工任务 请求体
/// <para>接口ID：7347562540447105025</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/transfer</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_task%2ftransfer</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApprovalTasksByApprovalTaskIdTransferBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "1783981209205788",
    "from_user_ids": [
        "1783981209205788"
    ],
    "to_user_ids": [
        "1783981209205789"
    ],
    "opinion": "转交"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApprovalTasksByApprovalTaskIdTransferBodyDto>(json);
        Assert.IsNotNull(result);
    }
}