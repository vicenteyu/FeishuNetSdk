// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-12-31
//
// Last Modified By : yxr
// Last Modified On : 2025-12-31
// ************************************************************************
// <copyright file="Test_GetApaasV1WorkspacesByWorkspaceIdEnumsByEnumNameResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自定义枚举详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取自定义枚举详细信息 响应体
/// <para>接口ID：7587254819413986517</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace-enum/enum_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace-enum%2fenum_get</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1WorkspacesByWorkspaceIdEnumsByEnumNameResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "name": "enum_name",
        "description": "enum描述",
        "options": [
            "enum_1"
        ],
        "created_at": "1765441837625",
        "created_by": {
            "id": "1693861178143800",
            "name": "王小小",
            "avatar": "https://xxx.image_url.com"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1WorkspacesByWorkspaceIdEnumsByEnumNameResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}