// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-05
//
// Last Modified By : yxr
// Last Modified On : 2025-12-05
// ************************************************************************
// <copyright file="Test_GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询数据表数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询数据表数据记录 响应体
/// <para>接口ID：7574027220335856583</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/records_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2frecords_get</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "total": 2,
        "items": "[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}