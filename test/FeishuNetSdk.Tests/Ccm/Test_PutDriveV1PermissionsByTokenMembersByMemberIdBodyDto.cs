// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutDriveV1PermissionsByTokenMembersByMemberIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新协作者权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新协作者权限 请求体
/// <para>接口ID：6998069547745230876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutDriveV1PermissionsByTokenMembersByMemberIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "openid",
    "perm": "view",
    "perm_type": "container",
    "type": "user"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PutDriveV1PermissionsByTokenMembersByMemberIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}