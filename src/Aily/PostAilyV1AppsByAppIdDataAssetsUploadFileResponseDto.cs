// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-16
//
// Last Modified By : yxr
// Last Modified On : 2025-05-16
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdDataAssetsUploadFileResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件用于数据知识管理 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 上传文件用于数据知识管理 响应体
/// <para>上传文件用于智能伙伴的数据知识管理</para>
/// <para>。</para>
/// <para>接口ID：7441589456115941379</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/upload_file</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2fupload_file</para>
/// </summary>
public record PostAilyV1AppsByAppIdDataAssetsUploadFileResponseDto
{
    /// <summary>
    /// <para>数据知识文件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_info")]
    public DataAssetFile? FileInfo { get; set; }

    /// <summary>
    /// <para>数据知识文件</para>
    /// </summary>
    public record DataAssetFile
    {
        /// <summary>
        /// <para>数据知识文件 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：file_token_abcd123</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>解析出的文件类型，包括pdf、docx、pptx、txt</para>
        /// <para>必填：是</para>
        /// <para>示例值：application/pdf</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; } = string.Empty;
    }
}
