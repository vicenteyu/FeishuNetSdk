// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-25
//
// Last Modified By : yxr
// Last Modified On : 2026-04-25
// ************************************************************************
// <copyright file="PostSparkV1AppsByAppIdStorageUploadPartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传文件 - 上传分片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 分片上传文件 - 上传分片 请求体
/// <para>根据`创建上传请求`接口返回的上传请求 ID 和分片策略上传对应的文件分片。全部上传完成后可调用`完成上传`接口完成文件分片上传。</para>
/// <para>接口ID：7631245788191296470</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-storage/upload_part</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-storage%2fupload_part</para>
/// </summary>
public record PostSparkV1AppsByAppIdStorageUploadPartBodyDto
{
    /// <summary>
    /// <para>上传请求 ID，可通过`分片上传文件 - 创建上传请求`获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：upload_abc123xyz456</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>分片编号从 1 开始</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最大值：10000</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("chunk_index")]
    public int ChunkIndex { get; set; }

    /// <summary>
    /// <para>对应分片文件的 md5</para>
    /// <para>必填：否</para>
    /// <para>示例值：ef176a6c424f954fa42d4cde03949897</para>
    /// </summary>
    [JsonPropertyName("chunk_check_sum")]
    public string? ChunkCheckSum { get; set; }
}
