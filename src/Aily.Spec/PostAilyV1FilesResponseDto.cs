// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="PostAilyV1FilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily.Spec;

/// <summary>
/// 上传文件 响应体
/// </summary>
public record PostAilyV1FilesResponseDto
{
    /// <summary>
    /// 文件列表
    /// </summary>
    [JsonPropertyName("files")]
    public FileInfo[] Files { get; set; } = [];

    /// <summary>
    /// 文件信息
    /// </summary>
    public record FileInfo
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// 文件Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }
    }
}
