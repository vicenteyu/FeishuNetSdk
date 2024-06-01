namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传文件-预上传 响应体
/// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/upload_part)做准备。平台固定以 4MB 的大小对文件进行分片。了解完整的上传文件流程，参考[上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
/// <para>接口ID：6979562676003815452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_prepare</para>
/// </summary>
public record PostDriveV1FilesUploadPrepareResponseDto
{
    /// <summary>
    /// <para>分片上传事务 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7111211691345512356</para>
    /// </summary>
    [JsonPropertyName("upload_id")]
    public string? UploadId { get; set; }

    /// <summary>
    /// <para>分片大小策略</para>
    /// <para>必填：否</para>
    /// <para>示例值：4194304</para>
    /// </summary>
    [JsonPropertyName("block_size")]
    public int? BlockSize { get; set; }

    /// <summary>
    /// <para>分片的数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("block_num")]
    public int? BlockNum { get; set; }
}
