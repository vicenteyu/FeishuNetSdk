// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="GetAilyV1FilesByFileIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>读取文件基础信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily.Spec;

/// <summary>
/// 读取文件基础信息 响应体
/// </summary>
public record GetAilyV1FilesByFileIdResponseDto
{
    /// <summary>
    /// 文件列表
    /// </summary>
    [JsonPropertyName("file")]
    public FileInfo? File { get; set; }

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

        /// <summary>
        /// 预览地址
        /// </summary>
        [JsonPropertyName("preview_url")]
        public PreviewUrlSuffix? PreviewUrl { get; set; }

        /// <summary>
        /// 预览地址
        /// </summary>
        public record PreviewUrlSuffix
        {
            /// <summary>
            /// 过期时间（秒）
            /// </summary>
            [JsonPropertyName("expired_at")]
            public string? ExpiredAt { get; set; }

            /// <summary>
            /// 链接地址
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }
    }
}
