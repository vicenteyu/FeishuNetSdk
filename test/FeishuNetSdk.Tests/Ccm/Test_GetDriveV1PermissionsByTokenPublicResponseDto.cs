// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1PermissionsByTokenPublicResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取云文档权限设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取云文档权限设置 响应体
/// <para>接口ID：7091106167506354178</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-public%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1PermissionsByTokenPublicResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "permission_public": {
            "external_access": true,
            "security_entity": "anyone_can_view",
            "comment_entity": "anyone_can_view",
            "share_entity": "anyone",
            "link_share_entity": "tenant_readable",
            "invite_external": true,
            "lock_switch": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1PermissionsByTokenPublicResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}