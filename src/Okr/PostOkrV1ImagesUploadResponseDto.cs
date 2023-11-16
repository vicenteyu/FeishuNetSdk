namespace FeishuNetSdk.Okr;
/// <summary>
/// 上传进展记录图片 响应体
/// <para>上传进展记录图片。</para>
/// <para>接口ID：7047048928294174722</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fimage%2fupload</para>
/// </summary>
public record PostOkrV1ImagesUploadResponseDto
{
    /// <summary>
    /// <para>图片token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxbcLxEnhUE3REJSAwAbVFZwPf</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>图片下载链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://bytedance.feishu.cn/drive/home/</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
