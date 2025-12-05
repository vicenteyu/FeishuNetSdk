// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PostApaasV1WorkspacesByWorkspaceIdSqlCommandsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 执行SQL 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 执行SQL 响应体
/// <para>接口ID：7574027220335840199</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace/sql_commands</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace%2fsql_commands</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1WorkspacesByWorkspaceIdSqlCommandsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "result": "[{\"name\":\"王一一\"}]"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1WorkspacesByWorkspaceIdSqlCommandsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}