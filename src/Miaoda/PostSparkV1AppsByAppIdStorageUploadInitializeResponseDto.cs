// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadInitializeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件 - 创建上传请求 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 分片上传文件 - 创建上传请求 响应体
/// <para>发送初始化请求，以获取上传请求 ID和分片策略，为上传分片做准备。获取结果后可调用`上传分片`接口完成文件分片上传。</para>
/// <para>接口ID：7631245788191280086</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_initialize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_initialize</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadInitializeResponseDto
{
    /// <summary>
    /// <para>上传请求 ID，有效期 24h</para>
    /// <para>必填：是</para>
    /// <para>示例值：upload_abc123xyz456</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>建议的分片大小（字节）</para>
    /// <para>必填：是</para>
    /// <para>示例值：4194304</para>
    /// </summary>
    [JsonPropertyName("chunk_size")]
    public int ChunkSize { get; set; }

    /// <summary>
    /// <para>预估的总分片数</para>
    /// <para>必填：是</para>
    /// <para>示例值：25</para>
    /// </summary>
    [JsonPropertyName("chunk_numbers")]
    public int ChunkNumbers { get; set; }
}
