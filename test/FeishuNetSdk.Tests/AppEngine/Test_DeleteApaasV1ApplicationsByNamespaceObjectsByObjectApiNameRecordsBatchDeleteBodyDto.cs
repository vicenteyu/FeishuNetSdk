// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量删除记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量删除记录 请求体
/// <para>接口ID：7384730094873083932</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_DeleteApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "1801464965461024"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.DeleteApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}