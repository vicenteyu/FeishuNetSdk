// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsByAppIdStorageUploadCompleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 分片上传文件 - 完成上传 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 分片上传文件 - 完成上传 请求体
/// <para>接口ID：7631245788191312854</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_complete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_complete</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsByAppIdStorageUploadCompleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "upload_id": "upload_abc123xyz456"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1AppsByAppIdStorageUploadCompleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}