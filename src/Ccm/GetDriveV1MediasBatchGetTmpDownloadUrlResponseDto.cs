// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1MediasBatchGetTmpDownloadUrlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取素材临时下载链接 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取素材临时下载链接 响应体
/// <para>该接口用于获取云文档中素材的临时下载链接。链接的有效期为 24 小时，过期失效。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口之前，你需确保应用已拥有素材的下载权限。否则接口将返回 403 的 HTTP 状态码。参考[云空间常见问题](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/faq)第 3 点了解如何分享素材的下载权限给应用。更多云文档接口权限问题，参考[云文档常见问题](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN)。</para>
/// <para>## 注意事项</para>
/// <para>本接口仅支持下载云文档而非云空间中的资源文件。如要下载云空间中的资源文件，需调用[下载文件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/download)接口。</para>
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
        /// <para>素材的 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
        /// </summary>
        [JsonPropertyName("file_token")]
        public string FileToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>素材的临时下载链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://internal-api-drive-stream.feishu.cn/space/api/box/stream/download/authcode/?code=ZDA3MzNiNmUwMjE2MGUzZmQ1OGZlOWYzMWQ4YmI0ZjdfMDYzOWNlZjgyMmI1MmY5NTUxZmM0MjJlYWIyMGVjOWZfSUQ6Njk3NjgzMTY0Mjc5OTI5MjQyMl8xNjI0NDMxMDY3OjE2MjQ1MTc0NjdfVjM</para>
        /// </summary>
        [JsonPropertyName("tmp_download_url")]
        public string TmpDownloadUrlSuffix { get; set; } = string.Empty;
    }
}
