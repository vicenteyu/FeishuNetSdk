// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdStorageUploadCompleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 分片上传文件 - 完成上传 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 分片上传文件 - 完成上传 响应体
/// <para>接口ID：7631245788191312854</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_complete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_complete</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdStorageUploadCompleteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_key": "1859988692091946",
        "file_url": "/app/app_4jmwuym484u90/runtime/api/v1/storage/object/bucket_aadju74v6daba/1859988692091946",
        "file_name": "上传文件名称示例",
        "file_size": 104857600,
        "mime_type": "text/plain; charset=utf-8"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdStorageUploadCompleteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}