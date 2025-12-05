// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 按条件更新数据表中的记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 按条件更新数据表中的记录 请求体
/// <para>接口ID：7574027220335889351</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_patch</para>
/// </summary>
[TestClass]
public class Test_PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "record": "{\"age\":10}"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PatchApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}