// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdStorageUploadInitializeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 分片上传文件 - 创建上传请求 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 分片上传文件 - 创建上传请求 响应体
/// <para>接口ID：7631245788191280086</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_initialize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_initialize</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdStorageUploadInitializeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "upload_id": "upload_abc123xyz456",
        "chunk_size": 4194304,
        "chunk_numbers": 25
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdStorageUploadInitializeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}