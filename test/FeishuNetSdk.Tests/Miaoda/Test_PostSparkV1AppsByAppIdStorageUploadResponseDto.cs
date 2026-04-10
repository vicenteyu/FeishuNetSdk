// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdStorageUploadResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 上传文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 上传文件 响应体
/// <para>接口ID：7624421835341695937</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdStorageUploadResponseDto : TestBase
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
        "file_name": "文件名称",
        "file_size": 33,
        "mime_type": "binary/octet-stream"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdStorageUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}