// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移除依赖 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 移除依赖 请求体
/// <para>接口ID：7277445986133442563</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/remove_dependencies</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_dependencies</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "dependencies": [
        {
            "task_guid": "93b7bd05-35e6-4371-b3c9-6b7cbd7100c0"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidRemoveDependenciesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}