namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 添加任务成员 请求体
/// <para>接口ID：7255580838154584092</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_members</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidAddMembersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "members": [
        {
            "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
            "type": "user",
            "role": "assignee"
        }
    ],
    "client_token": "6d99f59c-4d7d-4452-98d6-3d0556393cf6"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidAddMembersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}