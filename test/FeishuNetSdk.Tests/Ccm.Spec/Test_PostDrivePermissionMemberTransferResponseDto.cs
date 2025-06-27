// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDrivePermissionMemberTransferResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转移拥有者 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 转移拥有者 响应体
/// <para>接口ID：6907569744329719809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/transfer-ownership</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzNzUjL0czM14CN3MTN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionMemberTransferResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "is_success": true,
        "token": "string",
        "type": "doc",
        "owner": {
            "member_type": "openid",
            "member_id": "string"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostDrivePermissionMemberTransferResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}