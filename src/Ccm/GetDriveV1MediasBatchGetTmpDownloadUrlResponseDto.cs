namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取素材临时下载链接 响应体
/// <para>通过`file_tokens`获取素材临时下载链接，链接时效性是 24 小时，过期失效。</para>
/// <para>接口ID：6979562676003897372</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/batch_get_tmp_download_url</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fbatch_get_tmp_download_url</para>
/// </summary>
public record GetDriveV1MediasBatchGetTmpDownloadUrlResponseDto
{
    /// <summary>
    /// <para>临时下载列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tmp_download_urls")]
    public TmpDownloadUrl[]? TmpDownloadUrls { get; set; }

    /// <summary>
    /// <para>临时下载列表</para>
    /// </summary>
    public record TmpDownloadUrl
    {
        /// <summary>
        /// <para>文件标识符</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string FileToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件临时下载链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://internal-api-drive-stream.feishu.cn/space/api/box/stream/download/authcode/?code=ZDA3MzNiNmUwMjE2MGUzZmQ1OGZlOWYzMWQ4YmI0ZjdfMDYzOWNlZjgyMmI1MmY5NTUxZmM0MjJlYWIyMGVjOWZfSUQ6Njk3NjgzMTY0Mjc5OTI5MjQyMl8xNjI0NDMxMDY3OjE2MjQ1MTc0NjdfVjM</para>
        /// </summary>
        [JsonPropertyName("tmp_download_url")]
        public string TmpDownloadUrlSuffix { get; set; } = string.Empty;
    }
}
