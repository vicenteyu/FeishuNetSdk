// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 向数据表中添加或更新记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 向数据表中添加或更新记录 响应体
/// <para>接口ID：7574027220335872967</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_post</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_post</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "record_ids": [
            "1cbb280d-fc3d-4dca-9db5-adb14c4c83ec"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}