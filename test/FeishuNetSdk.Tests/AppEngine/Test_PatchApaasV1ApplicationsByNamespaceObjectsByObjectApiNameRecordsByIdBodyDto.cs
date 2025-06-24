// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 编辑记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 编辑记录 请求体
/// <para>接口ID：7384730094873034780</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record": "{\"_id\":\"1798681438085228\",\"book_count\":\"3\",\"book_name\":\"showcase2\"}"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}