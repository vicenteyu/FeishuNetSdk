// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1PermissionsByTokenMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 增加协作者权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 增加协作者权限 响应体
/// <para>接口ID：6987581166854635521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1PermissionsByTokenMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "member": {
            "member_type": "openid",
            "member_id": "ou_67e5ecb64ce1c0bd94612c17999db411",
            "perm": "view",
            "perm_type": "container",
            "type": "user"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1PermissionsByTokenMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}