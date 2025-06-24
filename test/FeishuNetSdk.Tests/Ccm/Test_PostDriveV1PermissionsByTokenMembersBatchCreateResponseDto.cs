// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDriveV1PermissionsByTokenMembersBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量增加协作者权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 批量增加协作者权限 响应体
/// <para>接口ID：7281248568152981507</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/permission/permission-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1PermissionsByTokenMembersBatchCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "members": [
            {
                "member_type": "openid",
                "member_id": "string",
                "perm": "view",
                "perm_type": "container",
                "type": "user"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1PermissionsByTokenMembersBatchCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}