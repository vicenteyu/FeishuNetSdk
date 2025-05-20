// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1FilesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件夹中的文件清单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件夹中的文件清单 响应体
/// <para>该接口用于获取用户云空间指定文件夹中文件信息清单。文件的信息包括名称、类型、token、创建时间、所有者 ID 等。</para>
/// <para>## 使用限制</para>
/// <para>本接口仅支持获取当前层级的文件信息，不支持递归获取子文件夹中的文件信息清单。</para>
/// <para>接口ID：7108600920377016348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2flist</para>
/// </summary>
public record GetDriveV1FilesResponseDto : IPageableResponse<GetDriveV1FilesResponseDto.File>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public File[]? Items => Files;

    /// <summary>
    /// <para>文件夹中的文件清单列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("files")]
    public File[]? Files { get; set; }

    /// <summary>
    /// <para>文件夹中的文件清单列表</para>
    /// </summary>
    public record File
    {
        /// <summary>
        /// <para>文件标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件名</para>
        /// <para>必填：是</para>
        /// <para>示例值：title</para>
        /// <para>最大长度：250</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型。可选值有：</para>
        /// <para>- `doc`：旧版文档</para>
        /// <para>- `sheet`：表格</para>
        /// <para>- `mindnote`：思维导图</para>
        /// <para>- `bitable`：多维表格</para>
        /// <para>- `file`：文件</para>
        /// <para>- `docx`：新版文档</para>
        /// <para>- `folder`：文件夹</para>
        /// <para>- `shortcut`: 快捷方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父文件夹标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonPropertyName("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>文件在浏览器中的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://feishu.cn/folder/fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>快捷方式类型文件的信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("shortcut_info")]
        public FileShortcutInfo? ShortcutInfo { get; set; }

        /// <summary>
        /// <para>快捷方式类型文件的信息</para>
        /// </summary>
        public record FileShortcutInfo
        {
            /// <summary>
            /// <para>快捷方式指向的原文件类型，包括：</para>
            /// <para>- `doc`：旧版文档</para>
            /// <para>- `sheet`：表格</para>
            /// <para>- `mindnote`：思维导图</para>
            /// <para>- `bitable`：多维表格</para>
            /// <para>- `file`：文件</para>
            /// <para>- `docx`：新版文档</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// </summary>
            [JsonPropertyName("target_type")]
            public string TargetType { get; set; } = string.Empty;

            /// <summary>
            /// <para>快捷方式指向的原文件 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：docxaO1UuPz8VwnpPx5a9abcef</para>
            /// </summary>
            [JsonPropertyName("target_token")]
            public string TargetToken { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>文件创建时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>文件最近修改时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonPropertyName("modified_time")]
        public string? ModifiedTime { get; set; }

        /// <summary>
        /// <para>文件所有者的 ID。ID 类型由查询参数中的 `user_id_type` 决定</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回下一次遍历的 page_token，否则不返回。</para>
    /// <para>必填：否</para>
    /// <para>示例值：MTY1NTA3MTA1OXw3MTA4NDc2MDc1NzkyOTI0Nabcef</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <inheritdoc/>
    [JsonPropertyName("page_token")]
    public string? PageToken { get { return NextPageToken; } set { NextPageToken = value; } }
}
