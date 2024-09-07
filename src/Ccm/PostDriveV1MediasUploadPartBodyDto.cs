// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MediasUploadPartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传素材-上传分片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材-上传分片 请求体
/// <para>根据 [预上传](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)接口返回的上传事务 ID 和分片策略上传对应的素材分片。上传完成后，你可调用 [分片上传素材（完成上传）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_finish)触发完成上传。</para>
/// <para>## 使用限制</para>
/// <para>该接口调用频率上限为 5 QPS，10000 次/天。</para>
/// <para>接口ID：6979562676003979292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_part</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_part</para>
/// </summary>
public record PostDriveV1MediasUploadPartBodyDto
{
    /// <summary>
    /// <para>分片上传事务的 ID。通过调用[分片上传素材（预上传）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7111211691345512356</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>块号，从 0 开始计数。</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("seq")]
    public int Seq { get; set; }

    /// <summary>
    /// <para>块的大小，单位为字节。</para>
    /// <para>必填：是</para>
    /// <para>示例值：4194304</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>素材文件的 Adler-32 校验和</para>
    /// <para>必填：否</para>
    /// <para>示例值：3248270248</para>
    /// </summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }
}
