// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 向数据表中添加或更新记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 向数据表中添加或更新记录 请求体
/// <para>接口ID：7574027220335872967</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_post</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_post</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": "[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]"
}
""";
        var result = Deserialize<FeishuNetSdk.AppEngine.PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}