namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 抄送人工任务 请求体
/// <para>接口ID：7446337145820332036</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fcc</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdCcBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "cc_user_ids": [
        "1234"
    ],
    "operator_user_id": "1234"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdCcBodyDto>(json);
        Assert.IsNotNull(result);
    }
}