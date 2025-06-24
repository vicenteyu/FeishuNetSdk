// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转移所有者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 转移所有者 请求体
/// <para>接口ID：7186547801970507777</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/transfer_owner</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2ftransfer_owner</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "member_type": "openid",
    "member_id": "ou_67e5ecb64ce1c0bd94612c17999db411"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1PermissionsByTokenMembersTransferOwnerBodyDto>(json);
        Assert.IsNotNull(result);
    }
}