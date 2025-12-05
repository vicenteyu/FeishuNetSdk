// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PostApaasV1WorkspacesByWorkspaceIdSqlCommandsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 执行SQL 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 执行SQL 请求体
/// <para>接口ID：7574027220335840199</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace%2fsql_commands</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1WorkspacesByWorkspaceIdSqlCommandsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "sql": "SELECT name FROM student"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1WorkspacesByWorkspaceIdSqlCommandsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}