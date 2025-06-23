namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 添加依赖 响应体
/// <para>接口ID：7277445986133458947</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_dependencies</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_dependencies</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidAddDependenciesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "dependencies": [
            {
                "type": "next",
                "task_guid": "93b7bd05-35e6-4371-b3c9-6b7cbd7100c0"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidAddDependenciesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}