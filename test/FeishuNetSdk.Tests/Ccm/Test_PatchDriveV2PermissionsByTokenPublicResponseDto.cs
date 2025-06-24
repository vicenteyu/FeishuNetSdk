// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchDriveV2PermissionsByTokenPublicResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新云文档权限设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新云文档权限设置 响应体
/// <para>接口ID：7224057619119128580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-public/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2fpermission-public%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDriveV2PermissionsByTokenPublicResponseDto : TestBase
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
            "external_access_entity": "open",
            "security_entity": "anyone_can_view",
            "comment_entity": "anyone_can_view",
            "share_entity": "anyone",
            "manage_collaborator_entity": "collaborator_can_view",
            "link_share_entity": "tenant_readable",
            "copy_entity": "anyone_can_view",
            "lock_switch": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PatchDriveV2PermissionsByTokenPublicResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}