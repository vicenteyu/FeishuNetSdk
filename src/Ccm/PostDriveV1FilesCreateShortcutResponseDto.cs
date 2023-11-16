namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文件快捷方式 响应体
/// <para>创建指定文件的快捷方式到云空间的其它文件夹中。此接口不支持在同一个文件夹下并发创建多个快捷方式。</para>
/// <para>接口ID：7216001760515112961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create_shortcut</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_shortcut</para>
/// </summary>
public record PostDriveV1FilesCreateShortcutResponseDto
{
    /// <summary>
    /// <para>快捷方式</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("succ_shortcut_node")]
    public File? SuccShortcutNode { get; set; }

    /// <summary>
    /// <para>快捷方式</para>
    /// </summary>
    public record File
    {
        /// <summary>
        /// <para>文件`Token`</para>
        /// <para>必填：是</para>
        /// <para>示例值：doxbcGvhSVN0R6octqPwAEYNfFb</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件名</para>
        /// <para>必填：是</para>
        /// <para>示例值：快捷方式名称</para>
        /// <para>最大长度：250</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型，可选值参照请求体的`refer_type`</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>父文件夹`Token`</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbc5qgwyQnO0uedNllWuF3fAd</para>
        /// </summary>
        [JsonPropertyName("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>访问链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/docx/doxbcGvhSVN0R6octqPwAEYNfFb</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>快捷方式源文件信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("shortcut_info")]
        public FileShortcutInfo? ShortcutInfo { get; set; }

        /// <summary>
        /// <para>快捷方式源文件信息</para>
        /// </summary>
        public record FileShortcutInfo
        {
            /// <summary>
            /// <para>快捷方式指向的源文件类型，可选值参照请求体的`refer_type`</para>
            /// <para>必填：是</para>
            /// <para>示例值：docx</para>
            /// </summary>
            [JsonPropertyName("target_type")]
            public string TargetType { get; set; } = string.Empty;

            /// <summary>
            /// <para>快捷方式指向的源文件`Token`</para>
            /// <para>必填：是</para>
            /// <para>示例值：doxbcGvhSVN0R6octqPwAEYNfFb</para>
            /// </summary>
            [JsonPropertyName("target_token")]
            public string TargetToken { get; set; } = string.Empty;
        }
    }
}
