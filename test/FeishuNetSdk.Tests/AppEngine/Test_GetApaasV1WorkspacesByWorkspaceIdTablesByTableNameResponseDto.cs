// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-31
//
// Last Modified By : yxr
// Last Modified On : 2025-12-31
// ************************************************************************
// <copyright file="Test_GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取数据表详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取数据表详细信息 响应体
/// <para>接口ID：7587254819414019285</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/table_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2ftable_get</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "name": "student",
        "description": "这是student表的描述",
        "columns": [
            {
                "name": "column_name",
                "description": "column_name的描述",
                "data_type": "varchar",
                "is_primary_key": false,
                "is_unique": false,
                "is_auto_increment": false,
                "is_array": false,
                "is_allow_null": false,
                "default_value": " "
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1WorkspacesByWorkspaceIdTablesByTableNameResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}