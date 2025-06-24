// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1UserTasksByTaskIdRollbackBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 退回人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 退回人工任务 请求体
/// <para>接口ID：7446337145820397572</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/rollback</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2frollback</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTasksByTaskIdRollbackBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator_user_id": "1234",
    "to_task_id": "1234",
    "opinion": "退回原因"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1UserTasksByTaskIdRollbackBodyDto>(json);
        Assert.IsNotNull(result);
    }
}