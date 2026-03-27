// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PostApplicationV7AppAvatarUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传应用图标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 上传应用图标 响应体
/// <para>接口ID：7621030901518568407</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/app_avatar-upload/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapp_avatar-upload%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV7AppAvatarUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "url": "https://s3-imfile.feishucdn.com/static-resource/v1/v3_006n_24c0a858-0b0d-490b-a8d4-b1e2ef421c8g"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV7AppAvatarUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}