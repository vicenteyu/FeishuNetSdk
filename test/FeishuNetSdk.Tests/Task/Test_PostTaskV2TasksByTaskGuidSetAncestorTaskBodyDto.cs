// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_PostTaskV2TasksByTaskGuidSetAncestorTaskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设置父任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 设置父任务 请求体
/// <para>接口ID：7645220598528183484</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/set_ancestor_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fset_ancestor_task</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidSetAncestorTaskBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ancestor_guid": "e297ddff-06ca-4166-b917-4ce57cd3a7a0"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidSetAncestorTaskBodyDto>(json);
        Assert.IsNotNull(result);
    }
}