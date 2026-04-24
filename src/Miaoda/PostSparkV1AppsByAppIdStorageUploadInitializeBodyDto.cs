// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadInitializeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件 - 创建上传请求 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 分片上传文件 - 创建上传请求 请求体
/// <para>发送初始化请求，以获取上传请求 ID和分片策略，为上传分片做准备。获取结果后可调用`上传分片`接口完成文件分片上传。</para>
/// <para>接口ID：7631245788191280086</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_initialize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_initialize</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadInitializeBodyDto
{
    /// <summary>
    /// <para>文件的名称，建议最大长度不超过100</para>
    /// <para>必填：是</para>
    /// <para>示例值：测试文本文件.txt</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的大小，单位为字节。</para>
    /// <para>必填：是</para>
    /// <para>示例值：104857600</para>
    /// <para>最大值：2147483648</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("file_size")]
    public int FileSize { get; set; }

    /// <summary>
    /// <para>文件 MIME 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：text/plain; charset=utf-8</para>
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }
}
