// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取记录详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取记录详情 请求体
/// <para>接口ID：7384730094873018396</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "select": [
        "_id"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}