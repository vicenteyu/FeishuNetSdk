// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1PermissionsByTokenMembersAuthResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 判断当前用户是否有某权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 判断用户云文档权限 响应体
/// <para>接口ID：7186547801970524161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/auth</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fauth</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1PermissionsByTokenMembersAuthResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "auth_result": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1PermissionsByTokenMembersAuthResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}