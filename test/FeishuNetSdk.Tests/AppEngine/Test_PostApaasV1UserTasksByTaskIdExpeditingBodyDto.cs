namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 催办人工任务 请求体
/// <para>接口ID：7446337145820348420</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/expediting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fexpediting</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdExpeditingBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator_user_id": "123",
    "expediting_user_ids": [
        "1234"
    ],
    "opinion": "催办理由"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdExpeditingBodyDto>(json);
        Assert.IsNotNull(result);
    }
}