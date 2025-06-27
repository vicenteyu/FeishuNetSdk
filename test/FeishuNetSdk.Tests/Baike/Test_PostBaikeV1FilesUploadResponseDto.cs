// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBaikeV1FilesUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 上传图片 响应体
/// <para>接口ID：7138031713099317252</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/file/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2ffile%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostBaikeV1FilesUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_token": "boxbcEcmKiD****vgqWTpvdc7jc"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostBaikeV1FilesUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}