// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更新数据表中的记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 批量更新数据表中的记录 请求体
/// <para>接口ID：7574027220335905735</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_batch_update</para>
/// </summary>
[TestClass]
public class Test_PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": "[{\"_id\":\"657fade8-394d-4d86-aa35-0129e3bd7614\",\"age\":10}]"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}