using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件夹下的清单 响应体
/// <para>获取用户云空间中指定文件夹下的文件清单。清单类型包括文件、各种在线文档（文档、电子表格、多维表格、思维笔记）、文件夹和快捷方式。该接口支持分页，但是不会递归获取子文件夹的清单。</para>
/// <para>接口ID：7108600920377016348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2flist</para>
/// </summary>
public record GetDriveV1FilesResponseDto
{
    /// <summary>
    /// <para>文件夹清单列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("files")]
    public File[]? Files { get; set; }

    /// <summary>
    /// <para>文件夹清单列表</para>
    /// </summary>
    public record File
    {
        /// <summary>
        /// <para>文件标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件名</para>
        /// <para>必填：是</para>
        /// <para>示例值：title</para>
        /// <para>最大长度：250</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型</para>
        /// <para>**可选值有**：</para>
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
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父文件夹标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonProperty("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>在浏览器中查看的链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://feishu.cn/folder/fldbcO1UuPz8VwnpPx5a9abcef</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("shortcut_info")]
        public FileShortcutInfo? ShortcutInfo { get; set; }

        /// <summary>
        /// <para>快捷方式文件信息</para>
        /// </summary>
        public record FileShortcutInfo
        {
            /// <summary>
            /// <para>快捷方式指向的原文件类型</para>
            /// <para>**可选值有**：</para>
            /// <para>- `doc`：旧版文档</para>
            /// <para>- `sheet`：表格</para>
            /// <para>- `mindnote`：思维导图</para>
            /// <para>- `bitable`：多维表格</para>
            /// <para>- `file`：文件</para>
            /// <para>- `docx`：新版文档</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// </summary>
            [JsonProperty("target_type")]
            public string TargetType { get; set; } = string.Empty;

            /// <summary>
            /// <para>快捷方式指向的原文件token</para>
            /// <para>必填：是</para>
            /// <para>示例值：docxaO1UuPz8VwnpPx5a9abcef</para>
            /// </summary>
            [JsonProperty("target_token")]
            public string TargetToken { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>文件创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonProperty("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>文件最近修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686125119</para>
        /// </summary>
        [JsonProperty("modified_time")]
        public string? ModifiedTime { get; set; }

        /// <summary>
        /// <para>文件所有者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回下一次遍历的page_token，否则则不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：MTY1NTA3MTA1OXw3MTA4NDc2MDc1NzkyOTI0Nabcef</para>
    /// </summary>
    [JsonProperty("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
