// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量编辑记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量编辑记录 请求体
/// <para>接口ID：7384730094872969244</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": "[{\"_id\":\"1798681438085228\",\"book_count\":\"5\",\"book_name\":\"name4\"}]"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}