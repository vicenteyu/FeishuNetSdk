// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutDriveV1PermissionsByTokenPublicPasswordResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 刷新密码 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 刷新云文档密码 响应体
/// <para>接口ID：7220305453616168964</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/permission-public-password/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public-password%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutDriveV1PermissionsByTokenPublicPasswordResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "password": "q795dji2"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PutDriveV1PermissionsByTokenPublicPasswordResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}