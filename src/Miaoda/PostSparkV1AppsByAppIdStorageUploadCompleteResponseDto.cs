// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadCompleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件 - 完成上传 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 分片上传文件 - 完成上传 响应体
/// <para>调用`上传分片`将分片全部上传完毕后，调用本接口触发完成上传。</para>
/// <para>接口ID：7631245788191312854</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_complete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_complete</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadCompleteResponseDto
{
    /// <summary>
    /// <para>文件 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：1859988692091946</para>
    /// </summary>
    [JsonPropertyName("file_key")]
    public string FileKey { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件 URL，相对路径</para>
    /// <para>必填：是</para>
    /// <para>示例值：/app/app_4jmwuym484u90/runtime/api/v1/storage/object/bucket_aadju74v6daba/1859988692091946</para>
    /// </summary>
    [JsonPropertyName("file_url")]
    public string FileUrl { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：上传文件名称示例</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件大小，单位字节</para>
    /// <para>必填：是</para>
    /// <para>示例值：104857600</para>
    /// </summary>
    [JsonPropertyName("file_size")]
    public int FileSize { get; set; }

    /// <summary>
    /// <para>文件 MIME 类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：text/plain; charset=utf-8</para>
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; } = string.Empty;
}
