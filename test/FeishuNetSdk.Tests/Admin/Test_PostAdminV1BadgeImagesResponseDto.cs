// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAdminV1BadgeImagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传勋章图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 上传勋章图片 响应体
/// <para>接口ID：7104154222309130243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge_image%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAdminV1BadgeImagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "image_key": "f02a98aa-1413-4af6-93ab-431ba9e5f2cg"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.PostAdminV1BadgeImagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}