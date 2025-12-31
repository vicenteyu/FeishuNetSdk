// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-31
//
// Last Modified By : yxr
// Last Modified On : 2025-12-31
// ************************************************************************
// <copyright file="Test_GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取工作空间下的数据表列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取工作空间下的数据表列表 响应体
/// <para>接口ID：7587254819414002901</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-table/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-table%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto : TestBase
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
        "page_token": "AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR",
        "items": [
            {
                "name": "student",
                "description": "studect数据表",
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
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1WorkspacesByWorkspaceIdTablesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}