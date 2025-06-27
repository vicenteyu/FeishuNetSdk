// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDrivePermissionV2PublicBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取云文档权限设置V2 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取云文档权限设置V2 请求体
/// <para>接口ID：6907569524099940353</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/permission/get-document-sharing-settings-v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITM3YjLyEzN24iMxcjN</para>
/// </summary>
[TestClass]
public class Test_PostDrivePermissionV2PublicBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
        "token": "doccnBKgoMyY5OMbUG6FioTXuBe",
        "type": "doc"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDrivePermissionV2PublicBodyDto>(json);
        Assert.IsNotNull(result);
    }
}