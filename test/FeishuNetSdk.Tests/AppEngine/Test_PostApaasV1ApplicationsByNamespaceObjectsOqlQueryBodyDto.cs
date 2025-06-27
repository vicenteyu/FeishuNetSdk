// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1ApplicationsByNamespaceObjectsOqlQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 执行 OQL 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 执行 OQL 请求体
/// <para>接口ID：7384730094873002012</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/oql_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2foql_query</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsOqlQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "SELECT _id, _name FROM _user WHERE _type = $1 AND _accountStatus = $user_status LIMIT 10",
    "args": "[\"_employee\"]",
    "named_args": "{\"user_status\" : \"_used\"}"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsOqlQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}