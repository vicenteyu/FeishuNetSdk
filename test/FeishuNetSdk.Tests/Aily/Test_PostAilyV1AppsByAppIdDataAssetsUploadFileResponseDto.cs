// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1AppsByAppIdDataAssetsUploadFileResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传文件用于数据知识管理 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 上传文件用于数据知识管理 响应体
/// <para>接口ID：7441589456115941379</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/upload_file</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2fupload_file</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AppsByAppIdDataAssetsUploadFileResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_info": {
            "token": "file_token_abcd123",
            "mime_type": "application/pdf"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1AppsByAppIdDataAssetsUploadFileResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}