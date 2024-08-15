// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCopyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 复制文件 响应体
/// <para>该接口用于将用户云空间中的文件复制至其它文件夹下。不支持复制文件夹。</para>
/// <para>## 使用限制</para>
/// <para>- 云空间中根目录或文件夹的单层节点上限为 1500 个。超过此限制时，接口将返回 1062507 错误码。可通过将文件复制到不同文件夹中解决。</para>
/// <para>- 云空间中所有层级的节点总和的上限为 40 万个。</para>
/// <para>- 该接口不支持并发调用，且调用频率上限为 5QPS 且 10000次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCopyResponseDto
{
    /// <summary>
    /// <para>复制的新文件信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file")]
    public PostDriveV1FilesByFileTokenCopyResponseDtoFile? File { get; set; }

    /// <summary>
    /// <para>复制的新文件信息</para>
    /// </summary>
    public record PostDriveV1FilesByFileTokenCopyResponseDtoFile
    {
        /// <summary>
        /// <para>复制的新文件 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：doxcnUkUOWtOelpFcha2Zabcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>新文件的名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：Demo copy</para>
        /// <para>最大长度：250</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>新文件的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>新文件的父文件夹 token</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
        /// </summary>
        [JsonPropertyName("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>文件在浏览器中的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://feishu.cn/docx/doxcnUkUOWtOelpFcha2Zabcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息（该参数不会返回）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("shortcut_info")]
        public PostDriveV1FilesByFileTokenCopyResponseDtoFileShortcutInfo? ShortcutInfo { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息（该参数不会返回）</para>
        /// </summary>
        public record PostDriveV1FilesByFileTokenCopyResponseDtoFileShortcutInfo
        {
            /// <summary>
            /// <para>快捷方式指向的源文件类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// </summary>
            [JsonPropertyName("target_type")]
            public string TargetType { get; set; } = string.Empty;

            /// <summary>
            /// <para>快捷方式指向的源文件 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：doxcnUkUOWtOelpFcha2Zabcef</para>
            /// </summary>
            [JsonPropertyName("target_token")]
            public string TargetToken { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>文件创建时间（该参数不会返回）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>文件最近修改时间（该参数不会返回）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("modified_time")]
        public string? ModifiedTime { get; set; }

        /// <summary>
        /// <para>文件所有者（该参数不会返回）</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }
    }
}
