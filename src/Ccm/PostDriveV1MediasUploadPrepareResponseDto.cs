namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材（预上传） 响应体
/// <para>发送初始化请求获取上传事务ID和分块策略，目前是以4MB大小进行定长分片。</para>
/// <para>接口ID：6979562676003848220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_prepare</para>
/// </summary>
public record PostDriveV1MediasUploadPrepareResponseDto
{
    /// <summary>
    /// <para>分片上传事务ID</para>
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
    /// <para>分片数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("block_num")]
    public int? BlockNum { get; set; }
}
