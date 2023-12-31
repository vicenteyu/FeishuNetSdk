namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传素材（上传分片） 请求体
/// <para>上传对应的文件块。</para>
/// <para>接口ID：6979562676003979292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_part</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_part</para>
/// </summary>
public record PostDriveV1MediasUploadPartBodyDto
{
    /// <summary>
    /// <para>分片上传事务ID。</para>
    /// <para>**示例值**："7111211691345512356"</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>块号，从0开始计数。</para>
    /// <para>**示例值**：0</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("seq")]
    public int Seq { get; set; }

    /// <summary>
    /// <para>块大小（以字节为单位）。</para>
    /// <para>**示例值**：4194304</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>文件分块adler32校验和(可选)。</para>
    /// <para>**示例值**："12345678"</para>
    /// <para>必填：否</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("checksum")]
    public string? Checksum { get; set; }
}
